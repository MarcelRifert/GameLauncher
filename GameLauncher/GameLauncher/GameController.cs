using System;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.Win32;
using System.Linq;
using System.Text;
using System.IO;

namespace GameLauncher
{
    class GameController
    {
        public List<Spiel> Spiele = new List<Spiel>();

        internal void Spiel_Entfernen(Spiel Spiel)
        {
            Spiele.Remove(Spiel);
        }

        internal void Spiel_Hinzufügen(string Pfad, string Genres, int USK)
        {
            if (!(File.Exists(Pfad)))
            {
                throw new ArgumentNullException("Die angegebene Datei existiert nicht!");
            }
            else
            {
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(Pfad);
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall"))
                {
                    foreach (string subkey_name in key.GetSubKeyNames())
                    {
                        using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                        {
                            if (subkey.GetValue("DisplayName") != null)
                                if (subkey.GetValue("DisplayName").ToString().Contains(fvi.ProductName))
                                {
                                    if (subkey.GetValue("InstallDate") != null)
                                    {
                                        string s = "";
                                        int year;
                                        int month;
                                        int day;
                                        s += subkey.GetValue("InstallDate").ToString()[0].ToString();
                                        s += subkey.GetValue("InstallDate").ToString()[1].ToString();
                                        s += subkey.GetValue("InstallDate").ToString()[2].ToString();
                                        s += subkey.GetValue("InstallDate").ToString()[3].ToString();
                                        year = Convert.ToInt32(s);
                                        s = "";
                                        s += subkey.GetValue("InstallDate").ToString()[4].ToString();
                                        s += subkey.GetValue("InstallDate").ToString()[5].ToString();
                                        month = Convert.ToInt32(s);
                                        s = "";
                                        s += subkey.GetValue("InstallDate").ToString()[6].ToString();
                                        s += subkey.GetValue("InstallDate").ToString()[7].ToString();
                                        day = Convert.ToInt32(s);

                                        Spiele.Add(new Spiel(fvi.ProductName, new DateTime(year, month, day), Pfad, Genres, subkey.GetValue("Publisher").ToString(), USK));
                                    }
                                }
                        }
                    }
                }
            }
        }

        internal void Spiel_Starten(Spiel Spiel)
        {
            Process.Start(Spiel.Pfad);
        }
    }
}
