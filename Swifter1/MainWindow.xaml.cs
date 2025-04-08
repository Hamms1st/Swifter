using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using Newtonsoft.Json;
using System.IO;
using System.Reflection;

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
        private int nextHotkeyId = 9000;
        public MainWindow()
        {
            InitializeComponent();
            //Main2.Content = new Load();
            MainFrame1.Content = new CreateShort();

            LoadAndRegisterShortcuts();


        }

        public class ShortcutInfo
        {
            public string ShortcutName { get; set; }
            public string Trigger { get; set; } // e.g., "Ctrl+Alt+M"
        }

        private void LoadAndRegisterShortcuts()
        {
            string jsonFile = "json\\shortcut.json";
            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, jsonFile);

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
                
                RegisterDynamicHotkey(shortcut.ShortcutName, nextHotkeyId++, mods, key);
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
                    case "ctrl": modifiers |= ModifierKeys.Control; break;
                    case "alt": modifiers |= ModifierKeys.Alt; break;
                    case "shift": modifiers |= ModifierKeys.Shift; break;
                    default:
                        key = (Key)Enum.Parse(typeof(Key), part, true); break;
                }
            }

        }

        private uint ModifierKeyToNative(ModifierKeys modifiers)
        {
            uint result = 0;
            if (modifiers.HasFlag(ModifierKeys.Control))
                { result |= 0x0002;
                
            }
            if (modifiers.HasFlag(ModifierKeys.Alt)) 
            {
                result |= 0x0001;
                
            }
            if (modifiers.HasFlag(ModifierKeys.Shift)) 
            {
                result |= 0x0004;
                        
            }
            
            return result;
        }

        public uint modifier;
        public uint vk;
        public int id1;
        private void RegisterDynamicHotkey(string shortcutName, int id, ModifierKeys modifiers, Key key)
        {
            
            modifier = ModifierKeyToNative(modifiers);
            vk = (uint)KeyInterop.VirtualKeyFromKey(key);
            id1 = id;
            dynamicHotkeyMap[id] = shortcutName;
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);
            var helper = new WindowInteropHelper(this);
            RegisterHotKey(helper.Handle,id1, modifier,vk);
            HwndSource source = HwndSource.FromHwnd(helper.Handle);
            source.AddHook(HwndHook);
        }

        private IntPtr HwndHook(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            
            const int WM_HOTKEY = 0x0312;

            if (msg == WM_HOTKEY && wParam.ToInt32() == 9000)
            {
                MessageBox.Show("Called");
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
                        // Create an instance of the class
                        var instance = Activator.CreateInstance(type);

                        // Get the 'main' method (non-static)
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

        private void RowDefinition_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.MouseLeftButtonDown += (s, e) =>
            {
                if (e.LeftButton == MouseButtonState.Pressed)
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
            MainFrame1.Content=new MainPage();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainFrame1.Content=new AutoPage();
        }
    }
}