using System;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using NAudio.CoreAudioApi;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Radios;
using WindowsInput;
using WindowsInput.Native;
using System.Windows.Input; namespace Swifter1 {    class Task
    {
private InputSimulator inputSimulator = new InputSimulator();
        public void main()
        {test ts = new test();
            bluetooth bt = new bluetooth();
            dark dt = new dark();
            Mute mt = new Mute();
            PasteText pt = new PasteText();
             OpenApp op = new OpenApp();
         battery bat = new battery();

            EndTask("Swifter1");


        }

        private void EndTask(string processName)
        {
            try
            {
                Process[] processes = Process.GetProcessesByName(processName);
                foreach (Process proc in processes)
                {
                    proc.Kill();
                    proc.WaitForExit(); // Optional: Wait until process fully exits
                }

                MessageBox.Show($"{processName} has been terminated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ending task: {ex.Message}");
            }
        }
    }
      }