using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Windows;
using System.Runtime.InteropServices;
using NAudio.CoreAudioApi;
using System.Diagnostics;
using Microsoft.Win32;



namespace Swifter1
{
    class test
    {
        public int main(int args)
        {

            switch (args)
            {

                case 0:
                    try
                    {
                        if (IsWiFiEnabled())
                        {
                            DisableWiFi();
                            return 1;
                        }
                        else
                        {
                            return 1; ;
                        }
                    }
                    catch (Exception e) { return 3; }

                case 1:
                    try
                    {
                        if (IsWiFiEnabled())
                        {
                            return 1;
                        }
                        else
                        {
                            EnableWiFi();
                            return 1;
                        }
                    }
                    catch (Exception e) { return 3; }

                case 2:
                    try
                    {
                        if (IsWiFiEnabled())
                        {
                            return 1;
                        }
                        return 0;
                    }
                    catch (Exception e) { return 3; }

                default:
                    return 0;


            }

        }



        private bool IsWiFiEnabled()
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/C netsh interface show interface name=\"Wi-Fi\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            return output.Contains("Enabled");
        }

        private void EnableWiFi()
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/C netsh interface set interface \"Wi-Fi\" admin=enabled",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();
            process.WaitForExit();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            if (!string.IsNullOrEmpty(error))
            {
                throw new Exception($"Failed to enable Wi-Fi: {error}");
            }
        }

        private void DisableWiFi()
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/C netsh interface set interface \"Wi-Fi\" admin=disabled",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();
            process.WaitForExit();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            if (!string.IsNullOrEmpty(error))
            {
                throw new Exception($"Failed to disable Wi-Fi: {error}");
            }
        }

    }
}