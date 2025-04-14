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
using System.Xml.Linq;

namespace Swifter1
{
    /// <summary>
    /// Interaction logic for ActionIN.xaml
    /// </summary>
    public partial class ActionIN : Page
    {
        public ActionIN()
        {
            InitializeComponent();
            LoadShortcuts();
            if (Application.Current.Properties.Contains("UserCount"))
            {


            }
            else
            {
                Application.Current.Properties["UserCount"] = 0;
            }

        }

        public int ac_count { get; set; }

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

       


        public void LoadShortcuts()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string projectDir = FindProjectDirectory();
            string path = Path.Combine(projectDir,"Temporary.json");

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                List<Step> shortcuts = JsonConvert.DeserializeObject<List<Step>>(json);

                if (shortcuts != null && shortcuts.Count > 0)
                {
                    foreach (var shortcut in shortcuts)
                    {
                        AddShortcutCard(shortcut);
                    }
                }
                else
                {
               
                }
            }

            else
            {
                MessageBox.Show("Shortcut file not found: " + path);
            }
        }

        public class Step
        {
            public string Title { get; set; }
            public string Count { get; set; }

            public String code {  get; set; }
        }

        
        
       

        private void OnStepClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Properties["UserCount"] = (int)Application.Current.Properties["UserCount"]+1 ;
            Application.Current.Properties["Gap"] = (int)Application.Current.Properties["Gap"]+1;
            Procedure procPage = new Procedure();
            NavigationService.Navigate(procPage);
            


        }
        
        private void OnIfClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Properties["UserCount"] = (int)Application.Current.Properties["UserCount"] + 1;
            Application.Current.Properties["Ifcount"]= (int)Application.Current.Properties["Ifcount"]+1;
            Application.Current.Properties["Gap"] = (int)Application.Current.Properties["Gap"] + 1;
            NavigationService.Navigate(new Ifcheck());
        }


        

        

        public void AddShortcutCard(Step shortcut)
        {
            Border card = new Border
            {
                BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#484848")),
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(10),
                Width = 450,
                Margin= new Thickness(5),
                Height = 35,
                Padding = new Thickness(2),
                Cursor = Cursors.Hand
            };

            card.MouseLeftButtonDown += (s, e) =>
            {
               
                
            };

            Style hoverStyle = new Style(typeof(Border));
            hoverStyle.Setters.Add(new Setter(Border.BackgroundProperty, Brushes.LightGray));
            Trigger hoverTrigger = new Trigger
            {
                Property = Border.IsMouseOverProperty,
                Value = true
            };
            hoverTrigger.Setters.Add(new Setter(Border.BackgroundProperty, Brushes.SlateGray));
            hoverStyle.Triggers.Add(hoverTrigger);

            card.Style = hoverStyle;


            StackPanel content = new StackPanel
            {
                Orientation = Orientation.Horizontal,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Center,
            };

            TextBlock title = new TextBlock
            {
                Text = "  Step ",
                HorizontalAlignment = HorizontalAlignment.Center,
                FontFamily = new FontFamily(new Uri("pack://application:,,,/"), "./Fonts/#Jost"),
                FontSize = 16,
                VerticalAlignment = VerticalAlignment.Center,
                Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#484848")),
                Margin = new Thickness(0, 0, 0, 2)
            };
            content.Children.Add(title);

            TextBlock count = new TextBlock
            {
                Text = shortcut.Count+" : "+shortcut.Title,
                HorizontalAlignment = HorizontalAlignment.Center,
                FontFamily = new FontFamily(new Uri("pack://application:,,,/"), "./Fonts/#Jost"),
                FontSize = 16,
                VerticalAlignment = VerticalAlignment.Center,
                Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#484848")),
                Margin = new Thickness(0, 0, 0, 2)
            };
            content.Children.Add(count);

            card.Child = content;
            StepsCOntainer.Children.Add(card);
        }

        private List<Step> steps = new List<Step>();


        private string shname = Application.Current.Properties["shname"].ToString();
        public string mainmeth = "\r\n    {\r\n        public void main()\r\n        {test ts = new test();\r\n            bluetooth bt = new bluetooth();\r\n            dark dt = new dark();\r\n            Mute mt = new Mute();\r\n            PasteText pt = new PasteText();\r\n             OpenApp op = new OpenApp();\r\n         battery bat = new battery();";

        private String import = "using System;\r\nusing System.Windows.Forms;\r\nusing System.Diagnostics;\r\nusing Microsoft.Win32;\r\nusing System.Runtime.InteropServices;\r\nusing NAudio.CoreAudioApi;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Text;\r\nusing System.Threading.Tasks;\r\nusing Windows.Devices.Radios;\r\nusing WindowsInput;\r\nusing WindowsInput.Native;\r\nusing System.Windows.Input; namespace Swifter1 {    class ";


        private void Endif_Click(object sender, RoutedEventArgs e)
        {
            if((int)Application.Current.Properties["Ifcount"] != 0)
            {
                Application.Current.Properties["Ifcount"] = (int)Application.Current.Properties["Ifcount"] - 1;
                Application.Current.Properties["Gap"] = 0;

                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string projectDir = FindProjectDirectory();
                string path = Path.Combine(projectDir, "Temporary.json");
                if (File.Exists(path))
                {
                    string existing = File.ReadAllText(path);
                    steps = JsonConvert.DeserializeObject<List<Step>>(existing) ?? new List<Step>();
                }
                
                string code = "}";
                string conca="";
                    conca = conca + code;
                    var st = new Step
                    {
                        Title = "EndIf",
                        code = conca
                    };
                    steps.Add(st);

                    String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                    File.WriteAllText(path, save);
                NavigationService.Navigate(new ActionIN());
                }
        }

        private void Else_Click(object sender, RoutedEventArgs e)
        {
            if ((int)Application.Current.Properties["Ifcount"] == 0)
            {
                if ((int)Application.Current.Properties["Gap"] == 0)
                {
                    Application.Current.Properties["Elsecount"] = (int)Application.Current.Properties["Elsecount"] + 1;
                    string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                    string projectDir = FindProjectDirectory();
                    string path = Path.Combine(projectDir, "Temporary.json");
                    if (File.Exists(path))
                    {
                        string existing = File.ReadAllText(path);
                        steps = JsonConvert.DeserializeObject<List<Step>>(existing) ?? new List<Step>();
                    }
                    string code = "else{";
                    string conca = "";
                    conca = conca + code;
                    var st = new Step
                    {
                        Title = "Else",
                        code = conca
                    };
                    steps.Add(st);
                    String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                    File.WriteAllText(path, save);
                    NavigationService.Navigate(new ActionIN());
                }

            }
            else
            {
                MessageBox.Show("Error");
            }
            
        }

        private void Elseend_Click(object sender, RoutedEventArgs e)
        {
            if ((int)Application.Current.Properties["Elsecount"] > 0)
            {
                if ((int)Application.Current.Properties["Gap"] == 0)
                {
                    if ((int)Application.Current.Properties["Ifcount"] == 0)
                    {
                        Application.Current.Properties["Elsecount"] = (int)Application.Current.Properties["Elsecount"] - 1;
                        string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                        string projectDir = FindProjectDirectory();
                        string path = Path.Combine(projectDir, "Temporary.json");
                        if (File.Exists(path))
                        {
                            string existing = File.ReadAllText(path);
                            steps = JsonConvert.DeserializeObject<List<Step>>(existing) ?? new List<Step>();
                        }

                        string code = "}";
                        string conca = "";
                        conca = conca + code;
                        var st = new Step
                        {
                            Title = "Endelse",
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


        private void OnLoopClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Properties["Loop"] = 0;
            NavigationService.Navigate(new Loop());
        }

        private void EndLoop_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Properties["Loop"] = (int)Application.Current.Properties["Loop"] - 1;
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string projectDir = FindProjectDirectory();
            string path = Path.Combine(projectDir, "Temporary.json");
            if (File.Exists(path))
            {
                string existing = File.ReadAllText(path);
                steps = JsonConvert.DeserializeObject<List<Step>>(existing) ?? new List<Step>();
            }

            string code = "}";
            string conca = "";
            conca = conca + code;
            var st = new Step
            {
                Title = "LoopEnd",
                code = conca
            };
            steps.Add(st);

            String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
            File.WriteAllText(path, save);
            NavigationService.Navigate(new ActionIN());
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Delay());
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {


            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string projectDir = FindProjectDirectory();
            string path = Path.Combine(projectDir, "Temporary.json");
            string concatenation = "";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                List<Step> shortcuts = JsonConvert.DeserializeObject<List<Step>>(json);
                foreach (var shortcut in shortcuts)
                {
                    concatenation += shortcut.code;
                }
                string close = "\r\n      }\r\n      }\r\n      }";
                concatenation += close;
                string projectDir2 = FindProjectDirectory();
                string fileName = Application.Current.Properties["shname"].ToString() + ".cs";
                string filePath = System.IO.Path.Combine(projectDir2, fileName);
                string csprojPath = System.IO.Path.Combine(projectDir2, "Swifter1.csproj");
                File.WriteAllText(filePath, concatenation);
                var doc = XDocument.Load(csprojPath);
                XNamespace ns = doc.Root.Name.Namespace;
                List<Shortcut> steps = new List<Shortcut>();
                string path2 = Path.Combine(projectDir2,"shortcut.json");
                if (File.Exists(path2))
                {
                    string existing1 = File.ReadAllText(path2);
                    steps = JsonConvert.DeserializeObject<List<Shortcut>>(existing1) ?? new List<Shortcut>();
                }
                var Short = new Shortcut
                {
                    ShortcutName = Application.Current.Properties["shname"].ToString(),
                    Trigger = Application.Current.Properties["Trigger"].ToString(),
                    IconPath = "/images/Short.png"
                };
                steps.Add(Short);
                String save2 = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(path2, save2);
                DOne.Visibility = Visibility.Visible;
                var pagenew = new CreateShort();
                pagenew.Change();

            }


        }

        public class Shortcut { 
        
            public string ShortcutName { get; set; }

            public string Trigger { get; set; }
            public string IconPath { get; set; }
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

    }
}
