using System;
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
using Newtonsoft.Json;

namespace Swifter1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
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

        private void LoadAndRegisterShortcuts()
        {
            string jsonFile = "json\\shortcut.json";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, jsonFile);

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

        private void ParseTrigger(string trigger, out ModifierKeys modifiers, out Key key)
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

        private uint ModifierKeyToNative(ModifierKeys modifiers)
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
            HwndSource source = HwndSource.FromHwnd(helper.Handle);
            source.AddHook(HwndHook);

            // Register all hotkeys stored in our list
            foreach (var registration in hotkeyRegistrations)
            {
                bool registered = RegisterHotKey(helper.Handle, registration.Id, registration.Modifiers, registration.VirtualKey);
                if (!registered)
                {
                    MessageBox.Show($"Failed to register hotkey: {registration.ShortcutName}");
                }
            }
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame1.Content = new MainPage();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainFrame1.Content = new AutoPage();
        }

        // Optionally, unregister all hotkeys when closing the window
        protected override void OnClosed(EventArgs e)
        {
            var helper = new WindowInteropHelper(this);
            foreach (var registration in hotkeyRegistrations)
            {
                UnregisterHotKey(helper.Handle, registration.Id);
            }
            base.OnClosed(e);
        }
    }
}
