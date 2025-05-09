﻿using System;
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
using System.Runtime.Intrinsics.Arm;


namespace Swifter1
{
    /// <summary>
    /// Interaction logic for MiniBoxT.xaml
    /// </summary>
    public partial class MiniBoxT : Page
    {
        public MiniBoxT()
        {
            InitializeComponent();
        }

        


        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
           
            String a = "";
            if (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl)){
                a += "Ctrl + ";
            }
            if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)){
                a += "Shift + ";
            }
            if (Keyboard.IsKeyDown(Key.LeftAlt) || Keyboard.IsKeyDown(Key.RightAlt)){
                a += "Alt + ";
            }
            if (Keyboard.IsKeyDown(Key.Tab))
            {
                a += "Tab + ";
            }
            if (Keyboard.IsKeyDown(Key.Space))
                a += "Space + ";
            if (Keyboard.IsKeyDown(Key.Back))
                a += "Backspace + ";
            if (Keyboard.IsKeyDown(Key.Escape))
                a += "Escape + ";
            if (Keyboard.IsKeyDown(Key.Delete))
                a += "Delete + ";
            if (Keyboard.IsKeyDown(Key.Insert))
                a += "Insert + ";
            if (Keyboard.IsKeyDown(Key.Up))
                a += "↑ + ";
            if (Keyboard.IsKeyDown(Key.Down))
                a += "↓ + ";
            if (Keyboard.IsKeyDown(Key.Left))
                a += "← + ";
            if (Keyboard.IsKeyDown(Key.Right))
                a += "→ + ";
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Key key = (Key)Enum.Parse(typeof(Key), c.ToString());
                if (Keyboard.IsKeyDown(key))
                {
                    a += c + " + ";
                    break;
                }
            }

            
            for (int i = 0; i <= 9; i++)
            {
                Key key = (Key)Enum.Parse(typeof(Key), "D" + i); // D0–D9 are the main number keys
                if (Keyboard.IsKeyDown(key))
                {
                    a += i + " + ";
                    break;
                }
            }

            if (a.EndsWith(" + "))
                a = a.Substring(0, a.Length - 3);
            Autoenter.Text = a;

        }

        private void Trigbut_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Properties["Trigger"] = Autoenter.Text;

            if (Application.Current.Properties.Contains("UserCount"))
            {
                Application.Current.Properties["UserCount"] = 0;
            }
            Application.Current.Properties["Ifcount"] = 0;
            Application.Current.Properties["Elsecount"] = 0;
            Application.Current.Properties["Gap"] = 0;
            Application.Current.Properties["Loop"] = 0;
            var parts = Autoenter.Text.Split(new[] { " + " }, StringSplitOptions.RemoveEmptyEntries);

            int modifierCount = 0;
            int otherKeyCount = 0;

            foreach (var part in parts)
            {
                if (part == "Ctrl" || part == "Shift" || part == "Alt")
                    modifierCount++;
                else
                    otherKeyCount++;
            }

            
            if (modifierCount >= 2 && otherKeyCount >= 1)
            {
                var Create= new CreateShort();
                Create.Trigbut_Set(Autoenter.Text);
                string projectDir = FindProjectDirectory();
                string path = Path.Combine(projectDir, "Temporary.json");
                File.WriteAllText(path, []);
                NavigationService.Navigate(new ActionIN());
            }
            else
            {
                Autoenter.Clear();
            }
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

        public String Auto;

    }
}
