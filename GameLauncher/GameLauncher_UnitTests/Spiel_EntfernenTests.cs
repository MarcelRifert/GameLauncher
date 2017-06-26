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
            Spiel TestSpiel = new Spiel("Dark Souls", new DateTime(2017, 06, 14), @"DarkSouls.exe", "Action", "From Software", 18);
            GameController.Spiele.Add(TestSpiel);

            GameController.Spiel_Entfernen(TestSpiel);

            Assert.AreEqual(GameController.Spiele.Count, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Spiel_Entfernen_Welches_Nicht_Hinzugeüfgt_wurde_Test()
        {
            Spiel TestSpiel = new Spiel("Dark Souls", new DateTime(2017, 06, 14), @"DarkSouls.exe", "Action", "From Software", 18);

            GameController.Spiel_Entfernen(TestSpiel);

            Assert.Fail();
        }
    }
}
