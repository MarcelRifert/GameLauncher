using System;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameLauncher
{
    [TestClass]
    public class Spiel_StartenTests
    {
        [TestMethod]
        public void Spiel_Starten_Test()
        {
            GameController GC = new GameController();
            List<string> TestKategorien = new List<string>();
            TestKategorien.Add("Action");
            Spiel TestSpiel = new Spiel("Dark Souls", new DateTime(2017, 06, 14), @"DarkSouls.exe", TestKategorien, "From Software", 18);
            GC.Spiele.Add(TestSpiel);

            GC.Spiel_Starten(TestSpiel);
            Process[] process = Process.GetProcessesByName("Dark Souls");

            Assert.AreNotEqual(process.Length, 0);
        }
    }
}
