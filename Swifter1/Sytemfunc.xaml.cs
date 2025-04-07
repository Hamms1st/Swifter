using Microsoft.CSharp;
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
        private string shname = "Firstshort";
        public string mainmeth = "\r\n    {\r\n        public void main()\r\n        {test ts = new test();\r\n            bluetooth bt = new bluetooth();\r\n            dark dt = new dark();\r\n            Mute mt = new Mute();";

        private String import = "using System;using System.Diagnostics;using Microsoft.Win32;using System.Runtime.InteropServices;using NAudio.CoreAudioApi;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using Windows.Devices.Radios;namespace Swifter1 {    class ";

        private void Ifwifion_Click(object sender, RoutedEventArgs e)
        {

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, jsonFileName);
            if (File.Exists(path))
            {
                string existing = File.ReadAllText(path);
                steps = JsonConvert.DeserializeObject<List<Step>>(existing) ?? new List<Step>();
            }
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
                File.WriteAllText(path,save);
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
                File.WriteAllText(path, save);
            }
        }



        private void Ifof_Click(object sender, RoutedEventArgs e)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, jsonFileName);
            if (File.Exists(path))
            {
                string existing = File.ReadAllText(path);
                steps = JsonConvert.DeserializeObject<List<Step>>(existing) ?? new List<Step>();
            }
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
                File.WriteAllText(path, save);
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
                File.WriteAllText(path, save);
            }
        }

        private void IfBlon_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
