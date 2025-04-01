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
            
        }

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
        }

       

        private void OnStepClick(object sender, RoutedEventArgs e)
        {
             
        }

        private void OnIfClick(object sender, RoutedEventArgs e)
        {
           

            
        }


        private void OnLoopClick(object sender, RoutedEventArgs e)
        {
       
            
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

    }
}
