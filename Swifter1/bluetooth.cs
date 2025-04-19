using System;
using Windows.Devices.Radios;
using System.Runtime.InteropServices.WindowsRuntime;  // for .AsTask()

namespace Swifter1
{
    class bluetooth
    {
        public int ret = 3;

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
                    catch (Exception)
                    {
                        return 3;
                    }

                case 1:
                    try
                    {
                        ToggleBluetooth(true);
                        return 1;
                    }
                    catch (Exception)
                    {
                        return 3;
                    }

                case 2:
                    try
                    {
                        ToggleBluetoothIfOff();
                        return ret;
                    }
                    catch (Exception)
                    {
                        return 3;
                    }

                default:
                    return 0;
            }
        }

        private void ToggleBluetooth(bool enable)
        {
            // Get the list of radios synchronously
            var radios = Radio.GetRadiosAsync()
                              .AsTask()
                              .Result;

            foreach (var radio in radios)
            {
                if (radio.Kind == RadioKind.Bluetooth)
                {
                    // Set state synchronously
                    var _ = radio.SetStateAsync(enable ? RadioState.On : RadioState.Off)
                                 .AsTask()
                                 .Result;
                    break;
                }
            }
        }

        private void ToggleBluetoothIfOff()
        {
            var radios = Radio.GetRadiosAsync()
                              .AsTask()
                              .Result;

            foreach (var radio in radios)
            {
                if (radio.Kind == RadioKind.Bluetooth)
                {
                    ret = (radio.State == RadioState.On) ? 1 : 0;
                    break;
                }
            }
        }
    }
}
