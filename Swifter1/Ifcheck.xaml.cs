using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.IO;

namespace Swifter1
{
    /// <summary>
    /// Interaction logic for Ifcheck.xaml
    /// </summary>
    public partial class Ifcheck : Page
    {
        public Ifcheck()
        {
            InitializeComponent();
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


        public class Step
        {
            public string Title { get; set; }
            public string Count { get; set; }

            public String code { get; set; }
        }
        
        private List<Step> steps = new List<Step>();

        
        private int count = (int)Application.Current.Properties["UserCount"];
        private string shname = Application.Current.Properties["shname"].ToString();
        public string mainmeth = "\r\n    {\r\n        public void main()\r\n        {test ts = new test();\r\n            bluetooth bt = new bluetooth();\r\n            dark dt = new dark();\r\n            Mute mt = new Mute();\r\n            PasteText pt = new PasteText();\r\n             OpenApp op = new OpenApp();\r\n         battery bat = new battery();";

        private String import = "using System;\r\nusing System.Windows.Forms;\r\nusing System.Diagnostics;\r\nusing Microsoft.Win32;\r\nusing System.Runtime.InteropServices;\r\nusing NAudio.CoreAudioApi;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Text;\r\nusing System.Threading.Tasks;\r\nusing Windows.Devices.Radios;\r\nusing WindowsInput;\r\nusing WindowsInput.Native;\r\nusing System.Windows.Input; namespace Swifter1 {    class ";

        private void Ifonwifi_Click(object sender, RoutedEventArgs e)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string projectDir = FindProjectDirectory();
            string path = Path.Combine(projectDir, "Temporary.json");
            if (File.Exists(path))
            {
                string existing = File.ReadAllText(path);
                steps = JsonConvert.DeserializeObject<List<Step>>(existing) ?? new List<Step>();
            }
            string code = "if(ts.main(2) == 1) \r\n            {";
            string conca;
            if (count == 1)
            {
                conca = import + shname + mainmeth;
                conca = conca + code;
                var st = new Step
                {
                    Title = "WifiOnCheck",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);

                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(path, save);
                NavigationService.Navigate(new ActionIN());
            }
            else
            {
                conca = code;
                var st = new Step
                {
                    Title = "WifiOnCheck",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);

                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(path, save);
                NavigationService.Navigate(new ActionIN());
            }
        }

        private void IfWifiof_Click(object sender, RoutedEventArgs e)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string projectDir = FindProjectDirectory();
            string path = Path.Combine(projectDir, "Temporary.json");
            if (File.Exists(path))
            {
                string existing = File.ReadAllText(path);
                steps = JsonConvert.DeserializeObject<List<Step>>(existing) ?? new List<Step>();
            }
            string code = "if(ts.main(2) == 0) \r\n            {";
            string conca;
            if (count == 1)
            {
                conca = import + shname + mainmeth;
                conca = conca + code;
                var st = new Step
                {
                    Title = "WifiOffCheck",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);

                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(path, save);
                NavigationService.Navigate(new ActionIN());
            }
            else
            {
                conca = code;
                var st = new Step
                {
                    Title = "WifiOffCheck",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);

                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(path, save);
                NavigationService.Navigate(new ActionIN());
            }
        }



        private void ButtonScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            var sv = sender as ScrollViewer;
            if (sv != null)
            {
                // Support Shift + Wheel for horizontal
                if (Keyboard.Modifiers == ModifierKeys.Shift)
                {
                    sv.ScrollToHorizontalOffset(sv.HorizontalOffset - e.Delta);
                    e.Handled = true;
                }
            }
        }

        private void IfBlon_Click(object sender, RoutedEventArgs e)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string projectDir = FindProjectDirectory();
            string path = Path.Combine(projectDir, "Temporary.json");
            if (File.Exists(path))
            {
                string existing = File.ReadAllText(path);
                steps = JsonConvert.DeserializeObject<List<Step>>(existing) ?? new List<Step>();
            }
            string code = "if(bt.main(2) == 1) \r\n            {";
            string conca;
            if (count == 1)
            {
                conca = import + shname + mainmeth;
                conca = conca + code;
                var st = new Step
                {
                    Title = "BluetoothOnCheck",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);

                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(path, save);
                NavigationService.Navigate(new ActionIN());
            }
            else
            {
                conca = code;
                var st = new Step
                {
                    Title = "BluetoothOnCheck",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);

                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(path, save);
                NavigationService.Navigate(new ActionIN());
            }
        }

        private void Ifblof_Click(object sender, RoutedEventArgs e)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string projectDir = FindProjectDirectory();
            string path = Path.Combine(projectDir, "Temporary.json");
            if (File.Exists(path))
            {
                string existing = File.ReadAllText(path);
                steps = JsonConvert.DeserializeObject<List<Step>>(existing) ?? new List<Step>();
            }
            string code = "if(bt.main(2) == 0) \r\n            {";
            string conca;
            if (count == 1)
            {
                conca = import + shname + mainmeth;
                conca = conca + code;
                var st = new Step
                {
                    Title = "BluetoothOffCheck",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);

                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(path, save);
                NavigationService.Navigate(new ActionIN());
            }
            else
            {
                conca = code;
                var st = new Step
                {
                    Title = "BluetoothOffCheck",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);

                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(path, save);
                NavigationService.Navigate(new ActionIN());
            }
        }

        private void IfNgon_Click(object sender, RoutedEventArgs e)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string projectDir = FindProjectDirectory();
            string path = Path.Combine(projectDir, "Temporary.json");
            if (File.Exists(path))
            {
                string existing = File.ReadAllText(path);
                steps = JsonConvert.DeserializeObject<List<Step>>(existing) ?? new List<Step>();
            }
            string code = "if(dt.main(2) == 1) \r\n            {";
            string conca;
            if (count == 1)
            {
                conca = import + shname + mainmeth;
                conca = conca + code;
                var st = new Step
                {
                    Title = "DarkModeOnCheck",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);

                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(path, save);
                NavigationService.Navigate(new ActionIN());
            }
            else
            {
                conca = code;
                var st = new Step
                {
                    Title = "DarkModeOnCheck",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);

                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(path, save);
                NavigationService.Navigate(new ActionIN());
            }
        }

        private void IfNgof_Click(object sender, RoutedEventArgs e)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string projectDir = FindProjectDirectory();
            string path = Path.Combine(projectDir, "Temporary.json");
            if (File.Exists(path))
            {
                string existing = File.ReadAllText(path);
                steps = JsonConvert.DeserializeObject<List<Step>>(existing) ?? new List<Step>();
            }
            string code = "if(dt.main(2) == 0) \r\n            {";
            string conca;
            if (count == 1)
            {
                conca = import + shname + mainmeth;
                conca = conca + code;
                var st = new Step
                {
                    Title = "DarkModeOffCheck",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);

                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(path, save);
                NavigationService.Navigate(new ActionIN());
            }
            else
            {
                conca = code;
                var st = new Step
                {
                    Title = "DarkModeOffCheck",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);

                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(path, save);
                NavigationService.Navigate(new ActionIN());
            }
        }

        private void IfAron_Click(object sender, RoutedEventArgs e)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string projectDir = FindProjectDirectory();
            string path = Path.Combine(projectDir, "Temporary.json");
            if (File.Exists(path))
            {
                string existing = File.ReadAllText(path);
                steps = JsonConvert.DeserializeObject<List<Step>>(existing) ?? new List<Step>();
            }
            string code = "if(mt.main(2) == 1) \r\n            {";
            string conca;
            if (count == 1)
            {
                conca = import + shname + mainmeth;
                conca = conca + code;
                var st = new Step
                {
                    Title = "MuteCheckOn",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);

                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(path, save);
                NavigationService.Navigate(new ActionIN());
            }
            else
            {
                conca = code;
                var st = new Step
                {
                    Title = "ModeCheckOn",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);

                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(path, save);
                NavigationService.Navigate(new ActionIN());
            }
        }

        private void IfArof_Click(object sender, RoutedEventArgs e)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string projectDir = FindProjectDirectory();
            string path = Path.Combine(projectDir, "Temporary.json");
            if (File.Exists(path))
            {
                string existing = File.ReadAllText(path);
                steps = JsonConvert.DeserializeObject<List<Step>>(existing) ?? new List<Step>();
            }
            string code = "if(mt.main(2) == 0) \r\n            {";
            string conca;
            if (count == 1)
            {
                conca = import + shname + mainmeth;
                conca = conca + code;
                var st = new Step
                {
                    Title = "MuteCheckOff",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);

                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(path, save);
                NavigationService.Navigate(new ActionIN());
            }
            else
            {
                conca = code;
                var st = new Step
                {
                    Title = "MuteCheckOff",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);

                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(path, save);
                NavigationService.Navigate(new ActionIN());
            }
        }

        private void IfChon_Click(object sender, RoutedEventArgs e)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string projectDir = FindProjectDirectory();
            string path = Path.Combine(projectDir, "Temporary.json");
            if (File.Exists(path))
            {
                string existing = File.ReadAllText(path);
                steps = JsonConvert.DeserializeObject<List<Step>>(existing) ?? new List<Step>();
            }
            int chex=Int32.Parse(checkstat.Text);
            string code = "if(bat.main(2) =="+chex.ToString()+" ) \r\n            {";
            string conca;
            if (count == 1)
            {
                conca = import + shname + mainmeth;
                conca = conca + code;
                var st = new Step
                {
                    Title = "If(BatteryCheck)",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);

                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(path, save);
                NavigationService.Navigate(new ActionIN());
            }
            else
            {
                conca = code;
                var st = new Step
                {
                    Title = "If(BatteryCheck)",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);

                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(path, save);
                NavigationService.Navigate(new ActionIN());
            }
        }
    }
}
