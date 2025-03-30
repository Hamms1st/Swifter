using System;
using System.Collections;
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
    /// Interaction logic for Welcome.xaml
    /// </summary>
    public partial class Welcome : Page
    {
        public Welcome()
        {
            InitializeComponent();



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var page2 = new MainPage();
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.MainFrame1.Content = page2;
            //Panel.SetZIndex(mainWindow.MainFrame1, 1);
            //Panel.SetZIndex(mainWindow.Main2, 0);
            /*
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0);
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                var routedEvent = FrameworkElement.UnloadedEvent;
                this.RaiseEvent(new RoutedEventArgs(routedEvent));
                DispatcherTimer timer2 = new DispatcherTimer();
                timer2.Interval = TimeSpan.FromSeconds(0.8);
                timer2.Tick += (s2, e2) =>
                {
                    
                    timer2.Stop();
                    mainWindow.Main2.Content = null;
                    mainWindow.MainFrame1.Content = page2;


                };
                timer2.Start();
                  
            };
            timer.Start();
            */

            /*var routedEvent = FrameworkElement.UnloadedEvent;
            this.RaiseEvent(new RoutedEventArgs(routedEvent));
            NavigationService.Navigate(null);*/

            var fadeOut = new DoubleAnimation
            {
                From = 1.0,
                To = 0.0,
                Duration = TimeSpan.FromSeconds(0.4),
                EasingFunction = new QuadraticEase { EasingMode = EasingMode.EaseInOut }
            };

            // Step 2: When fade-out completes
            fadeOut.Completed += (s, eArgs) =>
            {
                // Remove Main2 and show MainPage
                mainWindow.Main2.Content = null;
                
                mainWindow.MainFrame1.Content = new MainPage();
                mainWindow.showborder();
            };

            // Step 3: Apply the animation to Main2
            mainWindow.Main2.BeginAnimation(UIElement.OpacityProperty, fadeOut);

        }

    }
}
