using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Radios;

namespace Swifter1
{
    class bluetooth
    {
        public int main(int args)
        {

            switch (args)
            {

                case 0:
                    try
                    {
                       ToggleBluetooth(false);
                        return 1;

                    }
                    catch (Exception e) { return 3; }

                case 1:
                    try
                    {
                       ToggleBluetooth(true);
                        return 1;
                    }
                    catch (Exception e) { return 3; }

                case 2:
                    try
                    {
                        ToggleBluetoothIfOff();

                        return ret;
                    }
                    catch (Exception e) { return 3; }

                default:
                    return 0;


            }

        }

        private async Task ToggleBluetooth(bool enable)
        {
            var radios = await Radio.GetRadiosAsync();

            foreach (var radio in radios)
            {
                if (radio.Kind == RadioKind.Bluetooth)
                {
                    if (enable)
                    {
                        var result = await radio.SetStateAsync(RadioState.On);
                        

                    }
                    else
                    {
                        var result = await radio.SetStateAsync(RadioState.Off);
                        


                    }
                    break;
                }
            }
        }

        public int ret=3;

        private async  Task ToggleBluetoothIfOff()
        {
            var radios = await Radio.GetRadiosAsync();
            
            foreach (var radio in radios)
            {
                if (radio.Kind == RadioKind.Bluetooth)
                {
                    if (radio.State == RadioState.On)
                    {
                        ret = 1;
                    }
                    else
                    {
                        ret = 0;
                    }

                    break; 
                }
            }
            
        }


    }
}
