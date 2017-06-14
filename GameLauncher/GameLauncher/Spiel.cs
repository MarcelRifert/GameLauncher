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
        public string Pfad;
        private string _Kategorien;
        private string _Publisher;
        private int _USK;
        private bool _Favorit;

        public Spiel()
        {

        }

        #region Getter/Setter
        public string Titel
        {
            get { return _Titel; }
        }
        public string Kategorien
        {

        }
        #endregion
    }
}
