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
    /// Interaction logic for Ifcheck.xaml
    /// </summary>
    public partial class Ifcheck : Page
    {
        public Ifcheck()
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

        private void Ifonwifi_Click(object sender, RoutedEventArgs e)
        {
            string code = "if(ts.main(2) == 1) \r\n            {";
            string conca;
            if (count == 1)
            {
                conca = import + shname + mainmeth;
                conca = conca + code;
                var st = new Step
                {
                    Title = "WifiOnCheck",
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
                    Title = "WifiOnCheck",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);

                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(jsonFileName, save);
            }
        }

        private void IfWifiof_Click(object sender, RoutedEventArgs e)
        {
            string code = "if(ts.main(2) == 0) \r\n            {";
            string conca;
            if (count == 1)
            {
                conca = import + shname + mainmeth;
                conca = conca + code;
                var st = new Step
                {
                    Title = "WifiOffCheck",
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
                    Title = "WifiOffCheck",
                    Count = count.ToString(),
                    code = conca
                };
                steps.Add(st);

                String save = JsonConvert.SerializeObject(steps, Formatting.Indented);
                File.WriteAllText(jsonFileName, save);
            }
        }

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

        
    }
}
