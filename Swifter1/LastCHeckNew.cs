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
using System.Windows.Input; namespace Swifter1 {    class LastCHeckNew
    {
        public void main()
        {
            test ts = new test();
            bluetooth bt = new bluetooth();
            dark dt = new dark();
            Mute mt = new Mute();
            PasteText pt = new PasteText();
            OpenApp op = new OpenApp();
            battery bat = new battery();
            pt.main("HelloBoss"+bat.main().ToString());
            Thread.Sleep(400);
            if (bat.main() == 22)
            {
                pt.main("Okay it is Checked!");
            }
        }
    
      }
      }