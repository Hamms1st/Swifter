using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Swifter1
{
     class Energy
    {
        [DllImport("powrprof.dll", SetLastError = true)]
        public static extern uint PowerSetActiveScheme(IntPtr UserRootPowerKey, ref Guid SchemeGuid);

        // GUID for the Power Saver scheme.
        private static readonly Guid EnergySaverScheme = new Guid("a1841308-3541-4fab-bc81-f71556f20b4a");
        // GUID for the Balanced scheme.
        private static readonly Guid BalancedScheme = new Guid("381b4222-f694-41f0-9685-ff5bb260df2e");
        public void main()
        {
            EnergyOn();
        }

        private int EnergyOn()
        {
            Guid scheme = BalancedScheme;
            uint result = PowerSetActiveScheme(IntPtr.Zero, ref scheme);
            return 1;

        }
    }
}
