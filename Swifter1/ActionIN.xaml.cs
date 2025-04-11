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

        

        public string jsonFileName = "json\\Temporary.json";

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

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, jsonFileName);
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

            Procedure procPage = new Procedure();
            NavigationService.Navigate(procPage);
            


        }
        
        private void OnIfClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Properties["Ifcount"]= (int)Application.Current.Properties["Ifcount"]+1;
            NavigationService.Navigate(new Ifcheck());
        }


        private void OnLoopClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Loop());
            
        }

        

        public void AddShortcutCard(Step shortcut)
        {
            Border card = new Border
            {
                Background = new SolidColorBrush(Colors.LightGray),
                BorderBrush = new SolidColorBrush(Colors.DarkGray),
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(10),
                Width = 250,
                Margin = new Thickness(5),
                Padding = new Thickness(5),
                Cursor = Cursors.Hand
            };

            card.MouseLeftButtonDown += (s, e) =>
            {
               
                
            };


            StackPanel content = new StackPanel();

            TextBlock title = new TextBlock
            {
                Text = shortcut.Title,
                FontWeight = FontWeights.Light,
                HorizontalAlignment = HorizontalAlignment.Center,
                FontFamily = new FontFamily(new Uri("pack://application:,,,/"), "./Fonts/#Jost"),
                FontSize = 16,
                Margin = new Thickness(0, 0, 0, 2)
            };
            content.Children.Add(title);
            card.Child = content;
            StepsCOntainer.Children.Add(card);
        }

        private List<Step> steps = new List<Step>();


        private int count = (int)Application.Current.Properties["UserCount"];
        private string shname = "Firstshort";
        public string mainmeth = "\r\n    {\r\n        public void main()\r\n        {test ts = new test();\r\n            bluetooth bt = new bluetooth();\r\n            dark dt = new dark();\r\n            Mute mt = new Mute();\r\n            PasteText pt = new PasteText();\r\n             OpenApp op = new OpenApp();\r\n         battery bat = new battery();";

        private String import = "using System;\r\nusing System.Windows.Forms;\r\nusing System.Diagnostics;\r\nusing Microsoft.Win32;\r\nusing System.Runtime.InteropServices;\r\nusing NAudio.CoreAudioApi;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Text;\r\nusing System.Threading.Tasks;\r\nusing Windows.Devices.Radios;\r\nusing WindowsInput;\r\nusing WindowsInput.Native;\r\nusing System.Windows.Input; namespace Swifter1 {    class ";


        private void Endif_Click(object sender, RoutedEventArgs e)
        {
            if((int)Application.Current.Properties["Ifcount"] != 0)
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, jsonFileName);
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
                        Count = count.ToString(),
                        code = conca
                    };
                    steps.Add(st);

                    String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                    File.WriteAllText(path, save);
                }
            }
        }

        private void Else_Click(object sender, RoutedEventArgs e)
        {
            if ((int)Application.Current.Properties["Ifcount"] != 0)
            {
                Application.Current.Properties["Elsecount"] = (int)Application.Current.Properties["Elsecount"] + 1;
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, jsonFileName);
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
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);
                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(path, save);

            }
            else
            {
                MessageBox.Show("Error");
            }
            
        }

        private void Elseend_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EndLoop_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Delay());
        }

        
    }
}
