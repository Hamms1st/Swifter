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
using System.Windows.Input; namespace Swifter1 {    class bright
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
       Brightness brg = new Brightness();brg.main(1,1);Thread.Sleep(300);dt.main(1);
      }
      }
      }