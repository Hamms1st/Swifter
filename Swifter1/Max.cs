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
using System.Windows.Input; namespace Swifter1 {    class Max
    {
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_RESTORE = 9;
        private InputSimulator inputSimulator = new InputSimulator();
        public void main()
        {test ts = new test();
            bluetooth bt = new bluetooth();
            dark dt = new dark();
            Mute mt = new Mute();
            PasteText pt = new PasteText();
             OpenApp op = new OpenApp();
         battery bat = new battery();
            BringVisualStudioToFront();
            Thread.Sleep(800);
            inputSimulator.Keyboard.KeyDown(VirtualKeyCode.LCONTROL);
            Thread.Sleep(300);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.F5);
            Thread.Sleep(300);
           
            
            inputSimulator.Keyboard.KeyDown(VirtualKeyCode.LCONTROL);
            Thread.Sleep(300);
            inputSimulator.Keyboard.KeyDown(VirtualKeyCode.LSHIFT);
            Thread.Sleep(300);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_T);
            Thread.Sleep(0);
        }

        private void BringVisualStudioToFront()
        {
            // Search for all Visual Studio processes
            Process[] vsProcesses = Process.GetProcessesByName("devenv");

            if (vsProcesses.Length > 0)
            {
                Process vsProcess = vsProcesses[0]; // First instance
                IntPtr handle = vsProcess.MainWindowHandle;

                if (handle != IntPtr.Zero)
                {
                    ShowWindow(handle, SW_RESTORE);          // Restore if minimized
                    SetForegroundWindow(handle);             // Bring to front
                }
                else
                {
                    MessageBox.Show("Visual Studio window not found.");
                }
            }
            else
            {
                MessageBox.Show("Visual Studio is not running.");
            }
        }
    }
      }