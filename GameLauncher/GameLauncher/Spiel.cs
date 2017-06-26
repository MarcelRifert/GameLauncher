using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher
{
    class Spiel
    {
        private string _Titel;
        private DateTime _InstallationsDatum;
        public DateTime Zuletzt_gespielt;
        private string _Pfad;
        private string _Kategorien;
        private string _Publisher;
        private int _USK;
        public bool Favorit;

        public Spiel(string Titel, DateTime InstallationsDatum, string Pfad, string Kategorien, string Publisher, int USK)
        {
            _Titel = Titel;
            _InstallationsDatum = InstallationsDatum;
            _Pfad = Pfad;
            _Kategorien = Kategorien;
            _Publisher = Publisher;
            _USK = USK;
        }

        #region Getter/Setter
        public string Titel
        {
            get { return _Titel; }
        }
        public DateTime InstallationsDatum
        {
            get { return _InstallationsDatum; }
        }
        public string Pfad
        {
            get { return _Pfad; }
            set { _Pfad = value; }
        }
        public string Kategorien
        {
            get { return _Kategorien; }
        }
        public string Publisher
        {
            get { return _Publisher; }
        }
        public int USK
        {
            get { return _USK; }
        }
        #endregion
    }
}
