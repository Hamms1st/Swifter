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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Swifter1
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.showborder();
            LoadShortcuts();
        }

        public class Shortcut
        {
            public string ShortcutName { get; set; }

            public string Trigger { get; set; }
            public string IconPath { get; set; }
        }

        public void LoadShortcuts()
        {
            string jsonFileName = "json\\shortcut.json";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, jsonFileName);

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                List<Shortcut> shortcuts = JsonConvert.DeserializeObject<List<Shortcut>>(json);

                if (shortcuts != null && shortcuts.Count > 0)
                {
                    foreach (var shortcut in shortcuts)
                    {
                        AddShortcutCard(shortcut);
                    }
                }
                else
                {
                    NoShortcutsText.Visibility = Visibility.Visible;
                    empico.Visibility = Visibility.Visible;
                }
            }

            else
            {
                MessageBox.Show("Shortcut file not found: " + path);
            }
        }

        private void AddShortcutCard(Shortcut shortcut)
        {
            Border card = new Border
            {
                BorderBrush = new SolidColorBrush(Colors.DarkGray),
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(10),
                Width = 150,
                Height = 150,
                Margin = new Thickness(5),
                Padding = new Thickness(5),
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

            card.MouseLeftButtonDown += (s, e) =>
            {
                OnShortcutClick(shortcut); // Call backend logic
            };

            // Content inside the card
            StackPanel content = new StackPanel
            {
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Bottom
            };

            if (!string.IsNullOrEmpty(shortcut.IconPath))
            {
                Image icon = new Image
                {
                    Source = new BitmapImage(new Uri(shortcut.IconPath, UriKind.Relative)),
                    Width = 80,
                    Height = 80,
                    Margin = new Thickness(0, 0, 0, 5)
                };
                content.Children.Add(icon);
            }

            TextBlock title = new TextBlock
            {
                Text = shortcut.ShortcutName,
                FontWeight = FontWeights.Light,
                HorizontalAlignment = HorizontalAlignment.Center,
                FontFamily = new FontFamily(new Uri("pack://application:,,,/"), "./Fonts/#Jost"),
                FontSize = 21,
                Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121D55")),
                Margin = new Thickness(0, 0, 0, 2)
            };
            content.Children.Add(title);

            card.Child = content;

            // Finally, add to the container
            ShortcutsContainer.Children.Add(card);
        }

        public void OnShortcutClick(Shortcut shortcut)
        {
            MessageBox.Show($"You clicked: {shortcut.ShortcutName}");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreateShort());
            
        }
    }
    }
