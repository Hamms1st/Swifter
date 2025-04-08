using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace Swifter1
{
     class OpenApp
    {
        public void main(string url)
        {
            

            // If you're using a 32-bit version or if the installation path differs:
            // string operaPath = @"C:\Program Files (x86)\Opera\launcher.exe";

            if (File.Exists(url))
            {
                try
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true  // UseShellExecute is often required for opening external apps.
                    };

                    Process.Start(startInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error launching Opera:\n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Opera executable not found.\nPlease verify the installation path.", "Not Found", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    
    }
}
