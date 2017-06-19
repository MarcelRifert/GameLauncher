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
            Spiel TestSpiel = new Spiel("League of Legends", new DateTime(2017, 06, 14), @"E:\Riot Games\League of Legends\LeagueClient.exe", "Action", "Riot Games", 18);
            GC.Spiele.Add(TestSpiel);

            GC.Spiel_Starten(TestSpiel);
            Process[] process = Process.GetProcessesByName("LeagueClient");

            Assert.AreNotEqual(process.Length, 0);
        }
    }
}
