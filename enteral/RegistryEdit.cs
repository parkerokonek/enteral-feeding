using System;
using Microsoft.Win32;

namespace enteral
{
    class RegistryEdit
    {
        static RegistryEdit() { }
        static public int check_daily_start()
        {
            int daily_start = 6;
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\enteral_feeding"))
            {
                if (key != null)
                {
                    int tmp_start = -1;
                    Object o = key.GetValue("daily_start");
                    Int32.TryParse(o.ToString(), out tmp_start);
                    if (tmp_start < 24 && tmp_start > -1)
                    {
                        daily_start = tmp_start;
                    }
                }
            }
            return daily_start;
        }

        static public void set_daily_start(int val)
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\enteral_feeding"))
            {
                key.SetValue("daily_start", $"{val}");
            }
        }
    }


}
