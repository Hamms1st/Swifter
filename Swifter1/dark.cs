using Microsoft.Win32;

using System.Runtime.InteropServices;


namespace Swifter1
{
     class dark
    {

        public int main(int args)
        {

            switch (args)
            {

                case 0:
                    try
                    {
                        SetDarkMode(false);
                        return 1;

                    }
                    catch (Exception e) { return 3; }

                case 1:
                    try
                    {
                        SetDarkMode(true);
                        return 1;
                    }
                    catch (Exception e) { return 3; }

                case 2:
                    try
                    {
                        SetDarkMode(false);

                        return ret;
                    }
                    catch (Exception e) { return 3; }

                default:
                    return 0;


            }

        }

        public int ret = 3;

        const string RegistryKeyPath = @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";

        public static void SetDarkMode(bool darkMode)
        {
            // 0 = dark mode, 1 = light mode.
            int value = darkMode ? 0 : 1;
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryKeyPath, true))
            {
                if (key != null)
                {
                    key.SetValue("AppsUseLightTheme", value, RegistryValueKind.DWord);
                    key.SetValue("SystemUsesLightTheme", value, RegistryValueKind.DWord);
                }
                else
                {
                    throw new Exception("Registry key not found!");
                }
            }
           
        }

        private const uint WM_SETTINGCHANGE = 0x001A;

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessageTimeout(
            IntPtr hWnd,
            uint Msg,
            UIntPtr wParam,
            string lParam,
            uint uTimeout,
            out UIntPtr lpdwResult);
    }
}
