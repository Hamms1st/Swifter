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
using WindowsInput;
using WindowsInput.Native;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.IO;
using Newtonsoft.Json;

namespace Swifter1
{
    /// <summary>
    /// Interaction logic for Keystroke.xaml
    /// </summary>
    public partial class Keystroke : Page
    {
        public Keystroke()
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
        public string mainmeth = "\r\n    {\r\n      private InputSimulator inputSimulator = new InputSimulator();   public void main()\r\n        {test ts = new test();\r\n            bluetooth bt = new bluetooth();\r\n            dark dt = new dark();\r\n            Mute mt = new Mute();\r\n            PasteText pt = new PasteText();\r\n             OpenApp op = new OpenApp();\r\n         battery bat = new battery();";

        private String import = "using System;\r\nusing System.Windows.Forms;\r\nusing System.Diagnostics;\r\n using Microsoft.Win32;\r\n using System.Runtime.InteropServices;\r\n using NAudio.CoreAudioApi;\r\n using System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Text;\r\nusing System.Threading.Tasks;\r\nusing Windows.Devices.Radios;\r\nusing WindowsInput;\r\nusing WindowsInput.Native;\r\nusing System.Windows.Input; namespace Swifter1 {    class ";

        private List<VirtualKeyCode> recordedKeys = new List<VirtualKeyCode>();
        private InputSimulator inputSimulator = new InputSimulator();

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.Focusable = true;
            this.Focus();
            Keyboard.Focus(this);
        }
        public VirtualKeyCode keyCode;
        private void Page_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            
            if (Autoenter.Text == "SPACE")
            {
                keyCode = VirtualKeyCode.SPACE;
            }
            else if(Autoenter.Text == "DELETE")
            {
                keyCode = VirtualKeyCode.DELETE;
            }
            else
            {
                e.Handled = true;
                keyCode = KeyToVirtualKeyCode(e.Key);
            }
            
                if (keyCode != 0)
                {
                    Autoenter.Text = e.Key.ToString();
                }
            
        }

        private VirtualKeyCode KeyToVirtualKeyCode(Key key)
        {
            return (VirtualKeyCode)KeyInterop.VirtualKeyFromKey(key);
        }


        private void hold_Checked(object sender, RoutedEventArgs e)
        {
            hold.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121D55"));

        }


        private void release_Checked(object sender, RoutedEventArgs e)
        {
            release.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121D55"));

        }



        private void press_Checked(object sender, RoutedEventArgs e)
        {

            press.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121D55"));


        }

        public string code="";


        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            String a;
            if (Autoenter.Text != "")
            {
                if (hold.IsChecked == true)
                {
                    a = "KeyHold";
                    code += "inputSimulator.Keyboard.KeyDown(VirtualKeyCode.";

                }
                else if (release.IsChecked == true)
                {
                    a = "KeyRelease";
                    code += "inputSimulator.Keyboard.KeyUp(VirtualKeyCode.";
                }
                else
                {
                    a = "KeyPress";
                    code += "inputSimulator.Keyboard.KeyPress(VirtualKeyCode.";
                }
                code += keyCode + ");";
                code += "\r\n" + "Thread.Sleep(" + (float.Parse(delay.Text) * 1000) + ");\r\n";

            
                var addstroke = new Stroke
                {
                    KeyName = keyCode.ToString(),
                    Type = a,
                    Delay = delay.Text
                };



                try
                {
                    AddShortcutCard(addstroke);
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); };

            }

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string projectDir = FindProjectDirectory();
            string path = Path.Combine(projectDir, "Temporary.json");
            if (File.Exists(path))
            {
                string existing = File.ReadAllText(path);
                steps = JsonConvert.DeserializeObject<List<Step>>(existing) ?? new List<Step>();
            }
            string conca;
            if (count == 1)
            {
                conca = import + shname + mainmeth;
                conca = conca + code;
                var st = new Step
                {
                    Title = "KeyStroke",
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
                    Title = "KeyStroke",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);

                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(path, save);
                NavigationService.Navigate(new ActionIN());
            }
        }

        public class Stroke
        {
            public string KeyName { get; set; }

            public string Type {  get; set; }
            public string Delay { get; set; }



        }

        private List<Stroke> keyStrokeList = new List<Stroke>();


        private void AddShortcutCard(Stroke shortcut)
        {
            Border card = new Border
            {
                BorderBrush = new SolidColorBrush(Colors.DarkGray),
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(10),
                Width=450,
                Height = 35,
                Margin = new Thickness(5),
                Padding = new Thickness(2),
                Cursor = Cursors.Hand
            };

            // Hover effect style
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


            // Content inside the card
            StackPanel content = new StackPanel
            {
                Orientation = Orientation.Horizontal,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Center,
            };

            
                Image icon = new Image
                {
                    Source = new BitmapImage(new Uri("/images/keyboard.png", UriKind.Relative)),
                    Width = 32,
                    Height = 25,
                    Margin = new Thickness(0, 0, 0, 5),
                    VerticalAlignment = VerticalAlignment.Center,
                    
                };
                content.Children.Add(icon);
        
            TextBlock divider = new TextBlock
            {
                Text = " ",
                Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#484848")),
                FontSize = 16,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(5, 0, 5, 0)
            };
            content.Children.Add(divider);

            TextBlock title = new TextBlock
            {
                Text = "Key : "+shortcut.KeyName,
                
                HorizontalAlignment = HorizontalAlignment.Center,
                FontFamily = new FontFamily(new Uri("pack://application:,,,/"), "./Fonts/#Jost"),
                FontSize = 16,
                VerticalAlignment = VerticalAlignment.Center,
                Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#484848")),
                Margin = new Thickness(0, 0, 0, 2)
            };
            content.Children.Add(title);
            TextBlock Type = new TextBlock
            {
                Text = "    Type : "+shortcut.Type+"    ",
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                FontFamily = new FontFamily(new Uri("pack://application:,,,/"), "./Fonts/#Jost"),
                FontSize = 16,
                Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#484848")),
                Margin = new Thickness(0, 0, 0, 2)
            };
            content.Children.Add(Type);



            Image icon2 = new Image
                {
                    Source = new BitmapImage(new Uri("/images/timee.png", UriKind.Relative)),
                    Width = 20,
                    Height = 20,
                    Margin = new Thickness(0, 0, 0, 5),
                VerticalAlignment = VerticalAlignment.Center
            };
                content.Children.Add(icon2);
            

            TextBlock divider2 = new TextBlock
            {
                Text = " ",
                Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#484848")),
                FontSize = 16,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(5, 0, 5, 0)
            };
            content.Children.Add(divider2);

            TextBlock title2 = new TextBlock
            {
                Text = "Delay : " + shortcut.Delay,
                FontWeight = FontWeights.Light,
                HorizontalAlignment = HorizontalAlignment.Center,
                FontFamily = new FontFamily(new Uri("pack://application:,,,/"), "./Fonts/#Jost"),
                FontSize = 16,
                VerticalAlignment = VerticalAlignment.Center,
                Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#484848")),
                Margin = new Thickness(0, 0, 0, 2)
            };
            content.Children.Add(title2);

            card.Child = content;

            // Finally, add to the container
            ShortcutsContainer.Children.Add(card);
        }
    }
    }
