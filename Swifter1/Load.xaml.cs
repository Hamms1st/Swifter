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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Swifter1
{
    /// <summary>
    /// Interaction logic for Load.xaml
    /// </summary>
    public partial class Load : Page
    {
        public Load()
        {
            InitializeComponent();
            /*
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(2.5);
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                spin.IsLoading=true;
                DispatcherTimer timer2 = new DispatcherTimer();
                timer2.Interval = TimeSpan.FromSeconds(1.8);
                timer2.Tick += (s, e) =>
                {
                    timer2.Stop();
                    text.Visibility = Visibility.Visible;
                    timer.Interval = TimeSpan.FromSeconds(2);
                    timer.Tick += (s, e) =>
                    {
                        //var mainWindow = (MainWindow)Application.Current.MainWindow;
                        // mainWindow.showborder();


                        // Navigate to Page2 AFTER fade-out
                        timer.Stop();
                        NavigationService.Navigate(new Welcome());




                    };
                    timer.Start();
                    };
                timer2.Start();
            };
            timer.Start();
            */
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

                    text.Visibility = Visibility.Visible;

                    // Create a new timer for the final transition
                    DispatcherTimer transitionTimer = new DispatcherTimer();
                    transitionTimer.Interval = TimeSpan.FromSeconds(2);
                    transitionTimer.Tick += (s3, e3) =>
                    {
                        transitionTimer.Stop(); // Stop the transition timer
                        NavigationService.Navigate(new Welcome());
                    };
                    transitionTimer.Start(); // Start transition timer

                };
                timer2.Start(); // Start timer2 for loading sequence
            };

            timer.Start();

        }

        


    }
}
