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
    /// Interaction logic for Procedure.xaml
    /// </summary>
    public partial class Procedure : Page
    {
        public Procedure()
        {
            InitializeComponent();
        }

        private void Sys_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Sytemfunc());
        }
    }
}
