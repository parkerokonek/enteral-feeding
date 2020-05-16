using System;
using Microsoft.Win32;

namespace enteral
{
    class RegistryEdit
    {
        // This is a static class that wraps the functions for manipulating our single registry key
        static RegistryEdit() { }

        // Check daily start will attempt to read the key and set the daily start value if valid
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

        // Set daily start will set the value of the registry key to whatever is entered
        static public void set_daily_start(int val)
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\enteral_feeding"))
            {
                key.SetValue("daily_start", $"{val}");
            }
        }
    }


}
