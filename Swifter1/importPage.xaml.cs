using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Xml.Linq;

namespace Swifter1
{
    /// <summary>
    /// Interaction logic for importPage.xaml
    /// </summary>
    public partial class importPage : Page
    {
        public importPage()
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


        private string _jsonFile, _csFile;

        private void SelectJson_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json"
            };
            if (dlg.ShowDialog() == true)
            {
                _jsonFile = dlg.FileName;
                Json.Content= _jsonFile;

            }
        }

        private void SelectCs_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Filter = "C# files (*.cs)|*.cs"
            };
            if (dlg.ShowDialog() == true)
            {
                _csFile = dlg.FileName;
                Csharp.Content= _csFile;
            }
        }

        public class Shortcut
        {
            public string ShortcutName { get; set; }
            public string Trigger { get; set; }
            public string IconPath { get; set; }
        }

        private void Import_Click(object sender, RoutedEventArgs e)
        {
            string projectDir = FindProjectDirectory();

            // 1. Copy C# File
            if (!string.IsNullOrEmpty(_csFile))
            {
                string csContent = File.ReadAllText(_csFile);
                string newFileName = System.IO.Path.GetFileName(_csFile);
                string newFilePath = Path.Combine(projectDir, newFileName);
                File.WriteAllText(newFilePath, csContent);

                // Add to .csproj
                string csprojPath = Path.Combine(projectDir, "Swifter1.csproj");
                var doc = XDocument.Load(csprojPath);
                XNamespace ns = doc.Root.Name.Namespace;

            }

            // 2. Append JSON entry
            if (!string.IsNullOrEmpty(_jsonFile))
            {
                string uploadedJson = File.ReadAllText(_jsonFile);
                var newShortcut = JsonConvert.DeserializeObject<Shortcut>(uploadedJson);

                string shortcutPath = Path.Combine(projectDir, "shortcut.json");
                List<Shortcut> existingShortcuts = new List<Shortcut>();
                if (File.Exists(shortcutPath))
                {
                    string json = File.ReadAllText(shortcutPath);
                    existingShortcuts = JsonConvert.DeserializeObject<List<Shortcut>>(json) ?? new List<Shortcut>();
                }

                existingShortcuts.Add(newShortcut);
                File.WriteAllText(shortcutPath, JsonConvert.SerializeObject(existingShortcuts, Formatting.Indented));
            }

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(2.5);
            timer.Tick += (s, e) =>
            {
                timer.Stop(); // Stop the original timer

                spin.IsLoading = true;

                DispatcherTimer timer2 = new DispatcherTimer();
                timer2.Interval = TimeSpan.FromSeconds(1.8);
                timer2.Tick += (s2, e2) =>
                {
                    timer2.Stop(); // Stop the nested timer

                    DOne.Visibility = Visibility.Visible;

                    // Create a new timer for the final transition
                    DispatcherTimer transitionTimer = new DispatcherTimer();
                    transitionTimer.Interval = TimeSpan.FromSeconds(2);
                    transitionTimer.Tick += (s3, e3) =>
                    {
                        transitionTimer.Stop(); // Stop the transition timer
                        Max mx = new Max();
                        mx.main();
                    };
                    transitionTimer.Start(); // Start transition timer

                };
                timer2.Start(); // Start timer2 for loading sequence
            };

            timer.Start();


        }

    }



}
