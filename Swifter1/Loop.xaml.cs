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
    /// Interaction logic for Loop.xaml
    /// </summary>
    public partial class Loop : Page
    {
        public Loop()
        {
            InitializeComponent();
        }

        public class Step
        {
            public string Title { get; set; }
            public string Count { get; set; }

            public String code { get; set; }
        }
        public string jsonFileName = "json\\Temporary.json";
        private List<Step> steps = new List<Step>();


        private int count = (int)Application.Current.Properties["UserCount"];
        private string shname = "Firstshort";
        public string mainmeth = "\r\n    {\r\nprivate InputSimulator inputSimulator = new InputSimulator();\r\n        public void main()\r\n        {test ts = new test();\r\n            bluetooth bt = new bluetooth();\r\n            dark dt = new dark();\r\n            Mute mt = new Mute();\r\n            PasteText pt = new PasteText();\r\n             OpenApp op = new OpenApp();\r\n         battery bat = new battery();";

        private String import = "using System;\r\nusing System.Windows.Forms;\r\nusing System.Diagnostics;\r\nusing Microsoft.Win32;\r\nusing System.Runtime.InteropServices;\r\nusing NAudio.CoreAudioApi;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Text;\r\nusing System.Threading.Tasks;\r\nusing Windows.Devices.Radios;\r\nusing WindowsInput;\r\nusing WindowsInput.Native;\r\nusing System.Windows.Input; namespace Swifter1 {    class ";

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.Parse(Counttext.Text) > 0)
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, jsonFileName);
                if (File.Exists(path))
                {
                    string existing = File.ReadAllText(path);
                    steps = JsonConvert.DeserializeObject<List<Step>>(existing) ?? new List<Step>();
                }
                string code = "for(int i=0;i<" + Counttext.Text + ";i++) \r\n            {";
                string conca;
                if (count == 1)
                {
                    conca = import + shname + mainmeth;
                    conca = conca + code;
                    var st = new Step
                    {
                        Title = "Loop",
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
                        Title = "Loop",
                        Count = count.ToString(),
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
}
