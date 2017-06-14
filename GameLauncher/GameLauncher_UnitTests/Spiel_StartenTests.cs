using System;
using System.Diagnostics;
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
            string[] TestKategorien = new string[1];
            TestKategorien[0] = "Action";
            Spiel TestSpiel = new Spiel("Dark Souls", new DateTime(2017, 06, 14), @"DarkSouls.exe", TestKategorien, "From Software", 18);
            GC.Spiele.Add(TestSpiel);

            GC.Spiel_Starten(TestSpiel);
            Process[] process = Process.GetProcessesByName("Dark Souls");

            Assert.AreNotEqual(process.Length, 0);
        }
    }
}
