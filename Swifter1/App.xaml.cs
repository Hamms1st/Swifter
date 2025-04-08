using Microsoft.Win32;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Forms;
using System.IO;

namespace Swifter1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            AddToStartup();

            var window = new MainWindow();
            window.Hide();

            
        }

        private void ShowApp(Window window)
        {
            window.Show();
            window.WindowState = WindowState.Normal;
            window.Visibility = Visibility.Visible;
            window.ShowInTaskbar = true;
        }

        private void AddToStartup()
        {
            string appName = "Swifter";
            string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            key.SetValue(appName, $"\"{exePath}\"");
        }

    }

}
