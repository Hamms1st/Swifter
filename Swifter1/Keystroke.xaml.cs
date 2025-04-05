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
    /// Interaction logic for Keystroke.xaml
    /// </summary>
    public partial class Keystroke : Page
    {
        public Keystroke()
        {
            InitializeComponent();
            
        }



        private void hold_Checked(object sender, RoutedEventArgs e)
        {
            hold.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121D55"));
        
        }


        private void release_Checked(object sender, RoutedEventArgs e)
        {
            release.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121D55"));
           
        }

  

        private void press_Checked(object sender, RoutedEventArgs e)
        {

            press.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#121D55"));
        

        }



    }
}
