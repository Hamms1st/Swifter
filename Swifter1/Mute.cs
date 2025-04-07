using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swifter1
{
    class Mute
    {
        public int main(int args)
        {

            switch (args)
            {

                case 0:
                    try
                    {
                        MuteSwitch(0);
                        return 1;

                    }
                    catch (Exception e) { return 3; }

                case 1:
                    try
                    {
                        MuteSwitch(1);
                        return 1;
                    }
                    catch (Exception e) { return 3; }

                case 2:
                    try
                    {
                        int ret = MuteSwitchCheck();

                        return ret;
                    }
                    catch (Exception e) { return 3; }

                default:
                    return 0;


            }
        }

        private int MuteSwitch(int a)
        {
            var deviceEnumerator = new MMDeviceEnumerator();
            var device = deviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);

            bool isMuted = device.AudioEndpointVolume.Mute;
            try
            {
                if (a == 0)
                {
                    if (isMuted)
                    {
                        device.AudioEndpointVolume.Mute = false;
                        return 1;
                    }
                    return 3;
                }
                else
                {
                    if (!isMuted)
                    {
                        device.AudioEndpointVolume.Mute = true;
                        return 1;
                    }
                    return 3;
                }
            }
            catch(Exception) { return 3; }
        }

        private int MuteSwitchCheck()
        {
            var deviceEnumerator = new MMDeviceEnumerator();
            var device = deviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);

            bool isMuted = device.AudioEndpointVolume.Mute;
            try
            {
               
                    if (isMuted)
                    {
                        device.AudioEndpointVolume.Mute = false;
                        return 1;
                    }
                    else
                    {
                        device.AudioEndpointVolume.Mute = true;
                        return 0;
                    }
                
            }
            catch (Exception) { return 3; }
        }

    }
}
