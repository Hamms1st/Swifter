using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Swifter1
{
    class Brightness
    {

        public int main(int args,int setvalue)
        {
            if (args == 0)
            {
                return GetCurrentBrightness();
            }
            else
            {
                SetBrightness(setvalue);
                return 1;
            }
        }

        private int GetCurrentBrightness()
        {
            using (var searcher = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM WmiMonitorBrightness"))
            {
                foreach (var obj in searcher.Get())
                {
                    return Convert.ToInt32(obj["CurrentBrightness"]);
                }
            }
            throw new Exception("Cannot retrieve current brightness.");
        }
        private void SetBrightness(int brightness)
        {
            using (var searcher = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM WmiMonitorBrightnessMethods"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    obj.InvokeMethod("WmiSetBrightness", new object[] { UInt32.MaxValue, (byte)brightness });
                    break;
                }
            }
        }
    }
}
