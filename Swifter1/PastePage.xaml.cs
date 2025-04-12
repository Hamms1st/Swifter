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
    /// Interaction logic for PastePage.xaml
    /// </summary>
    public partial class PastePage : Page
    {

        public PastePage()
        {
            InitializeComponent();
            Confirm.Focus();
        }
        public int countnew = 0;

        public class Step
        {
            public string Title { get; set; }
            public string Count { get; set; }

            public String code { get; set; }
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

        private List<Step> steps = new List<Step>();

        
        private int count = (int)Application.Current.Properties["UserCount"];
        private string shname = Application.Current.Properties["shname"].ToString();
        public string mainmeth = "\r\n    {\r\n        public void main()\r\n        {test ts = new test();\r\n            bluetooth bt = new bluetooth();\r\n            dark dt = new dark();\r\n            Mute mt = new Mute();\r\n            PasteText pt = new PasteText();\r\n             OpenApp op = new OpenApp();\r\n         battery bat = new battery();";

        private String import = "using System;\r\nusing System.Windows.Forms;\r\nusing System.Diagnostics;\r\nusing Microsoft.Win32;\r\nusing System.Runtime.InteropServices;\r\nusing NAudio.CoreAudioApi;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Text;\r\nusing System.Threading.Tasks;\r\nusing Windows.Devices.Radios;\r\nusing WindowsInput;\r\nusing WindowsInput.Native;\r\nusing System.Windows.Input; namespace Swifter1 {    class ";

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string projectDir = FindProjectDirectory();
            string path = Path.Combine(projectDir, "Temporary.json");
            if (File.Exists(path))
            {
                string existing = File.ReadAllText(path);
                steps = JsonConvert.DeserializeObject<List<Step>>(existing) ?? new List<Step>();
            }
            string code = "\r\n            pt.main("+Maintext.Text+");";
            string conca;
            if (count == 1)
            {
                conca = import + shname + mainmeth;
                conca = conca + code;
                var st = new Step
                {
                    Title = "Paste",
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
                    Title = "Paste",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);

                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(path, save);
                NavigationService.Navigate(new ActionIN());
            }
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (countnew == 0) { 
            countnew++;
                Maintext.Text = "";
            }
        }


    }
}
