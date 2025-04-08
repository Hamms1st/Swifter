using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swifter1
{
     class battery
    {
        public int main()
        {
            float batteryLifePercent = SystemInformation.PowerStatus.BatteryLifePercent * 100;
            int a = (int)batteryLifePercent;
            return a;
        }
    }
}
