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
            Spiel TestSpiel = new Spiel("Rechner", new DateTime(2017, 06, 14), @"C:\Windows\System32\calc.exe", "Action", "Microsoft", 0);
            GameController.Spiele.Add(TestSpiel);

            GameController.Spiel_Starten(TestSpiel);
            Process[] process = Process.GetProcessesByName("calc");

            Assert.AreNotEqual(process.Length, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Spiel_Starten_Welches_Nicht_In_Der_Liste_ist_Test()
        {
            Spiel TestSpiel = new Spiel("Rechner", new DateTime(2017, 06, 14), @"C:\Windows\System32\calc.exe", "Action", "Microsoft", 0);

            GameController.Spiel_Starten(TestSpiel);

            Assert.Fail();
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Spiel_Starten_Inkorrekter_Pfad()
        {
            Spiel TestSpiel = new Spiel("Rechner", new DateTime(2017, 06, 14), "", "Action", "Microsoft", 0);
            GameController.Spiele.Add(TestSpiel);

            GameController.Spiel_Starten(TestSpiel);

            Assert.Fail();
        }
    }
}
