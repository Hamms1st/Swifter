﻿using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
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
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Reflection;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Windows.Devices.Radios;


namespace Swifter1
{
    /// <summary>
    /// Interaction logic for Sytemfunc.xaml
    /// </summary>
    public partial class Sytemfunc : Page
    {
        public Sytemfunc()
        {
            InitializeComponent();


        }



        public class Step
        {
            public string Title { get; set; }
            public string Count { get; set; }

            public String code { get; set; }
        }

        private List<Step> steps = new List<Step>();

        public string jsonFileName = "json\\Temporary.json";


        private int count = (int)Application.Current.Properties["UserCount"];
        private string shname = "firstshort";
        public string mainmeth = "\r\n    {\r\n        public void main()\r\n        {test ts = new test();";

        private String import = "using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Text;\r\nusing System.Threading.Tasks;\r\n\r\nnamespace Swifter1\r\n{\r\n    class ";

        private void Ifwifion_Click(object sender, RoutedEventArgs e)
        {
            string code = "\r\n            ts.main(1);";
            string conca;
            if (count == 1)
            {
                conca = import + shname+mainmeth;
                conca = conca + code;
                var st = new Step
                {
                    Title = "WifiOn",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);
                
                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(jsonFileName,save);
            }
            else
            {
                conca =code;
                var st = new Step
                {
                    Title = "WifiOn",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);

                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(jsonFileName, save);
            }
        }



        private void Ifof_Click(object sender, RoutedEventArgs e)
        {
            string code = "ts.main(0);";
            string conca;
            if (count == 1)
            {
                conca = import + shname + mainmeth;
                conca = conca + code;
                var st = new Step
                {
                    Title = "WifiOff",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);

                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(jsonFileName, save);
            }
            else
            {
                conca = code;
                var st = new Step
                {
                    Title = "WifiOff",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);

                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(jsonFileName, save);
            }
        }

        private void IfBlon_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
