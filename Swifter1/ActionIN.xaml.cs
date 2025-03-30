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
        }

        public string jsonFileName = "json\\Temporary.json";
        
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
                else
                {
                    MessageBox.Show("Woops!");
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
            public string Key { get; set; }
            public string Count { get; set; }
        }

       

        private void OnStepClick(object sender, RoutedEventArgs e)
        {
            // Example shortcut data
            var newShortcut = new Step
            {
                Title = "Click",
                Key = "0",
                Count = ((StepsCOntainer.Children.Count)+1).ToString()
            };

            AddShortcutCard(newShortcut);
        }

        private void OnIfClick(object sender, RoutedEventArgs e)
        {
            // Example shortcut data
            var newShortcut = new Step
            {
                Title = "Click",
                Key = "1",
                Count = ((StepsCOntainer.Children.Count) + 1).ToString()
            };

            AddShortcutCard(newShortcut);
        }


        private void OnLoopClick(object sender, RoutedEventArgs e)
        {
            // Example shortcut data
            var newShortcut = new Step
            {
                Title = "Click",
                Key = "2",
                Count = ((StepsCOntainer.Children.Count) + 1).ToString()
            };

            AddShortcutCard(newShortcut);
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
                Height = 30,
                Margin = new Thickness(5),
                Padding = new Thickness(5),
                Cursor = Cursors.Hand
            };

            card.MouseLeftButtonDown += (s, e) =>
            {
                if (shortcut.Key == "0") 
                {
                    if (Int32.Parse(shortcut.Count) == StepsCOntainer.Children.Count) {
                        MessageBox.Show("Hoo");
                    }
                    else
                    {
                        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, jsonFileName);
                        File.WriteAllText(path,"[]");
                        NavigationService.Navigate(new ActionIN());
                    }
                }
                if (shortcut.Key == "1") {

                    MessageBox.Show("Its a If!");
                }
                if (shortcut.Key == "2") {
                    MessageBox.Show("Its a Loop");
                }
                
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
