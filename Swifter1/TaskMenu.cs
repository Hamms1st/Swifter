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
using System.Windows.Input; namespace Swifter1 {    class TaskMenu
    {
      private InputSimulator inputSimulator = new InputSimulator();   public void main()
        {test ts = new test();
            bluetooth bt = new bluetooth();
            dark dt = new dark();
            Mute mt = new Mute();
            PasteText pt = new PasteText();
             OpenApp op = new OpenApp();
         battery bat = new battery();
            Thread.Sleep(300);
            inputSimulator.Keyboard.KeyDown(VirtualKeyCode.LCONTROL);
Thread.Sleep(300);
inputSimulator.Keyboard.KeyPress(VirtualKeyCode.ESCAPE);
Thread.Sleep(0);
inputSimulator.Keyboard.KeyUp(VirtualKeyCode.LCONTROL);
            Thread.Sleep(300);
            pt.main("Whatsapp");
            Thread.Sleep(300);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            Thread.Sleep(1500);
            pt.main("you");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(200);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            Thread.Sleep(500);
            pt.main("I have Joined!");
            Thread.Sleep(200);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);


        }
      }
      }