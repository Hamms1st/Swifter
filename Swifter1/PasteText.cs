using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;
using System.Windows.Input;
namespace Swifter1
{
     class PasteText
    {
        private InputSimulator inputSimulator = new InputSimulator();
        public int main(string a)
        {
            try
            {
                PasteTextToActiveWindow(a);
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public void PasteTextToActiveWindow(string text)
        {
            // Step 1: Copy the text to the clipboard
            Clipboard.SetText(text);

            // Optionally, wait a short period to ensure the clipboard is set
            
            inputSimulator.Keyboard.KeyDown(VirtualKeyCode.RCONTROL);
            Thread.Sleep(800);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_V);
            inputSimulator.Keyboard.KeyUp(VirtualKeyCode.RCONTROL);


        }
    }
}
