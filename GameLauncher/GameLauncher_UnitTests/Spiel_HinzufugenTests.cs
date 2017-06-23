using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameLauncher
{
    [TestClass]
    public class Spiel_HinzufugenTests
    {
        [TestMethod]
        public void Spiel_Hinzufügen_Test()
        {
            GameController.Spiel_Hinzufügen(@"E:\Riot Games\League of Legends\LeagueClient.exe", "Action", 18);

            Assert.AreEqual(GameController.Spiele.Count, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Nicht_Installiertes_Spiel_Hinzufügen()
        {  
            GameController.Spiel_Hinzufügen("n.A.", "Action", 0);

            Assert.Fail();
        }
    }
}
