using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameLauncher
{
    [TestClass]
    public class Spiel_EntfernenTests
    {
        [TestMethod]
        public void Spiel_Entfernen_Test()
        {
            GameController GC = new GameController();
            Spiel TestSpiel = new Spiel("Dark Souls", new DateTime(2017, 06, 14), @"DarkSouls.exe", "Action", "From Software", 18);
            GC.Spiele.Add(TestSpiel);

            GC.Spiel_Entfernen(TestSpiel);

            Assert.AreEqual(GC.Spiele.Count, 0);
        }
    }
}
