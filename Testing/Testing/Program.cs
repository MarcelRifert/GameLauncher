using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Spiel_starten("Firefox");
            Spiele();
            Console.ReadKey();
        }
        public static void Spiel_starten(string Spiel)
        {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall"))
            {
                foreach (string subkey_name in key.GetSubKeyNames())
                {
                    using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                    {
                        if (subkey.GetValue("DisplayName") != null)
                        {
                            if (subkey.GetValue("DisplayName").ToString().Contains(Spiel))
                            {
                                string s = subkey.GetValue("DisplayIcon").ToString();
                                s = s.Remove(s.Length - 2);
                                Process.Start(s);
                            }
                        }
                    }
                }
            }
        }

        public static void Spiele()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_Product");
            foreach (ManagementObject mo in mos.Get())
            {
                Console.WriteLine(mo["Name"]);
            }
        }
    }
}
