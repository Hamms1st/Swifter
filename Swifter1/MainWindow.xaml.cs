﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Navigation;
using Newtonsoft.Json;

namespace Swifter1
{

    public partial class MainWindow : Window
    {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private Dictionary<int, string> dynamicHotkeyMap = new Dictionary<int, string>();
        
        private List<HotkeyRegistration> hotkeyRegistrations = new List<HotkeyRegistration>();

        // Starting ID (increments for each registration)
        private int nextHotkeyId = 9000;

        public class HotkeyRegistration
        {
            public int Id { get; set; }
            public uint Modifiers { get; set; }
            public uint VirtualKey { get; set; }
            public string ShortcutName { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();
            LoadAndRegisterShortcuts();
            Main2.Content = new Load();
            Main2.Navigated += MainFrame1_Navigated;
        }

        private void MainFrame1_Navigated(object sender, NavigationEventArgs e)
        {
            // Check the type of page now loaded in the frame
            if (e.Content is Welcome || e.Content is Load)
            {
                Below.Visibility = Visibility.Collapsed;
            }
            else
            {
                Below.Visibility = Visibility.Visible;
            }
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;      // Prevent app from closing
            this.Hide();          // Just hide the window
        }

        public class ShortcutInfo
        {
            public string ShortcutName { get; set; }
            public string Trigger { get; set; } // e.g., "Ctrl+Alt+M"
        }

        private static string FindProjectDirectory()
        {
            string current = AppDomain.CurrentDomain.BaseDirectory;

            while (current != null && !Directory.GetFiles(current, "*.csproj").Any())
            {
                current = Directory.GetParent(current)?.FullName;
            }

            return current ?? throw new Exception("Could not find project directory.");
        }

        public void LoadAndRegisterShortcuts()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string projectDir = FindProjectDirectory();
            string path = Path.Combine(projectDir,"shortcut.json");

            if (!File.Exists(path))
            {
                MessageBox.Show("Shortcut config file not found.");
                return;
            }

            string json = File.ReadAllText(path);
            var shortcuts = JsonConvert.DeserializeObject<List<ShortcutInfo>>(json);

            foreach (var shortcut in shortcuts)
            {
                ParseTrigger(shortcut.Trigger, out ModifierKeys mods, out Key key);

                
                HotkeyRegistration registration = new HotkeyRegistration
                {
                    Id = nextHotkeyId++,
                    Modifiers = ModifierKeyToNative(mods),
                    VirtualKey = (uint)KeyInterop.VirtualKeyFromKey(key),
                    ShortcutName = shortcut.ShortcutName
                };

                
                hotkeyRegistrations.Add(registration);
                
                dynamicHotkeyMap[registration.Id] = shortcut.ShortcutName;
            }
        }

        public void ParseTrigger(string trigger, out ModifierKeys modifiers, out Key key)
        {
            modifiers = ModifierKeys.None;
            key = Key.None;

            var parts = trigger.Split('+');
            foreach (var part in parts.Select(p => p.Trim()))
            {
                switch (part.ToLower())
                {
                    case "ctrl":
                        modifiers |= ModifierKeys.Control;
                        break;
                    case "alt":
                        modifiers |= ModifierKeys.Alt;
                        break;
                    case "shift":
                        modifiers |= ModifierKeys.Shift;
                        break;
                    default:
                        key = (Key)Enum.Parse(typeof(Key), part, true);
                        break;
                }
            }
        }

        public uint ModifierKeyToNative(ModifierKeys modifiers)
        {
            uint result = 0;
            if (modifiers.HasFlag(ModifierKeys.Control))
                result |= 0x0002;
            if (modifiers.HasFlag(ModifierKeys.Alt))
                result |= 0x0001;
            if (modifiers.HasFlag(ModifierKeys.Shift))
                result |= 0x0004;
            return result;
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);
            var helper = new WindowInteropHelper(this);
            _hwnd = helper.Handle;
            _hwndSource = HwndSource.FromHwnd(_hwnd);
            _hwndSource.AddHook(HwndHook);
            foreach (var registration in hotkeyRegistrations)
            {
                bool registered = RegisterHotKey(_hwnd, registration.Id, registration.Modifiers, registration.VirtualKey);
                if (!registered)
                {
                    MessageBox.Show($"Failed to register hotkey: {registration.ShortcutName}");
                }
            }
        }

        public void RefreshHotkeys()
        {
            if (_hwnd == IntPtr.Zero) return;

            // 1) Unregister all existing
            foreach (var reg in hotkeyRegistrations)
            {
                UnregisterHotKey(_hwnd, reg.Id);
            }

            // 2) Clear our lists
            hotkeyRegistrations.Clear();
            dynamicHotkeyMap.Clear();
            nextHotkeyId = 9000;  // reset if you like; or leave monotonic

            // 3) Reload from JSON
            string projectDir = FindProjectDirectory();
            string path = Path.Combine(projectDir, "shortcut.json");
            if (!File.Exists(path))
            {
                MessageBox.Show("Shortcut file not found for refresh.");
                return;
            }

            var json = File.ReadAllText(path);
            var list = JsonConvert.DeserializeObject<List<ShortcutInfo>>(json);
            if (list == null) return;

            // 4) Parse and register each one
            foreach (var sc in list)
            {
                ParseTrigger(sc.Trigger, out var mods, out var key);
                var nativeMods = ModifierKeyToNative(mods);
                var vk = (uint)KeyInterop.VirtualKeyFromKey(key);
                int id = nextHotkeyId++;

                // store
                hotkeyRegistrations.Add(new HotkeyRegistration
                {
                    Id = id,
                    Modifiers = nativeMods,
                    VirtualKey = vk,
                    ShortcutName = sc.ShortcutName
                });
                dynamicHotkeyMap[id] = sc.ShortcutName;

                // register
                bool ok = RegisterHotKey(_hwnd, id, nativeMods, vk);
                if (!ok)
                    MessageBox.Show($"Failed to re-register '{sc.ShortcutName}' → {sc.Trigger}");
            }

            MessageBox.Show("✅ Hotkeys refreshed!");
        }

        public void UnregisterAllHotkeys()
        {
            if (_hwnd == IntPtr.Zero) return;

            foreach (var reg in hotkeyRegistrations)
                UnregisterHotKey(_hwnd, reg.Id);

            // Clean slate
            hotkeyRegistrations.Clear();
            dynamicHotkeyMap.Clear();
            nextHotkeyId = 9000;
        }

        private IntPtr HwndHook(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            const int WM_HOTKEY = 0x0312;
            if (msg == WM_HOTKEY)
            {
                int id = wParam.ToInt32();
                
                if (dynamicHotkeyMap.TryGetValue(id, out string shortcutName))
                {
                    
                    InvokeShortcutMethod(shortcutName);
                    handled = true;
                }
            }
            return IntPtr.Zero;
        }

      

        private void InvokeShortcutMethod(string className)
        {
            try
            {
                var assemblies = AppDomain.CurrentDomain.GetAssemblies();

                foreach (var asm in assemblies)
                {
                    var type = asm.GetType("Swifter1." + className);
                    if (type != null)
                    {
                        var instance = Activator.CreateInstance(type);
                        var method = type.GetMethod("main", BindingFlags.Public | BindingFlags.Instance);
                        method?.Invoke(instance, null);
                        return;
                    }
                }

                MessageBox.Show($"Shortcut class '{className}' not found.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error running shortcut '{className}':\n{ex.Message}");
            }
        }

        // Example UI event handlers (for window dragging, minimizing, closing, etc.)
        private void RowDefinition_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.MouseLeftButtonDown += (s, eArgs) =>
            {
                if (eArgs.LeftButton == MouseButtonState.Pressed)
                {
                    this.DragMove();
                }
            };
        }

        public void RegisterNewHotkey(string shortcutName, string trigger)
        {
            ParseTrigger(trigger, out var mods, out var key);
            uint nativeMods = ModifierKeyToNative(mods);
            uint vk = (uint)KeyInterop.VirtualKeyFromKey(key);

            // 2) pick a fresh ID
            int id = nextHotkeyId++;

            // 3) remember it for unregistering
            hotkeyRegistrations.Add(new HotkeyRegistration
            {
                Id = id,
                Modifiers = nativeMods,
                VirtualKey = vk,
                ShortcutName = shortcutName
            });
            dynamicHotkeyMap[id] = shortcutName;

            // 4) call RegisterHotKey on *this* window handle
            bool ok = RegisterHotKey(_hwnd, id, nativeMods, vk);
            MessageBox.Show(ok
      ? $"✅ Hotkey #{id} registered for '{shortcutName}' → {trigger}"
      : $"❌ Failed to register #{id} for '{shortcutName}' → {trigger}");
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Cross_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void showborder()
        {
            Below.Visibility = Visibility.Visible;
        }
        private HwndSource _hwndSource;
        private IntPtr _hwnd;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Main2.Content = new MainPage();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Main2.Content = new AutoPage();
        }

        // Optionally, unregister all hotkeys when closing the window
        protected override void OnClosed(EventArgs e)
        {

            foreach (var reg in hotkeyRegistrations)
            {
                UnregisterHotKey(_hwnd, reg.Id);
            }
            base.OnClosed(e);
        }
    }
}
