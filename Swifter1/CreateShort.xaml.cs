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
using System.Windows.Shapes;


namespace Swifter1
{
    /// <summary>
    /// Interaction logic for CreateShort.xaml
    /// </summary>
    public partial class CreateShort : Page
    {
        public CreateShort()
        {
            InitializeComponent();
            Miniframe.Content = new ActionIN();

        }

        private void Stepbut_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Clicked");
        }

        private void Trigbut_Click(object sender, RoutedEventArgs e)
        {

            Miniframe.Content = new MiniBoxT();


        }

        public void Trigbut_Set(String auto)
        {
           Trigbut.Content = auto;
        }
    }
}
