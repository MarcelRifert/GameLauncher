using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameLauncher
{
    [TestClass]
    public class Spiel_HinzufugenTests
    {
        [TestMethod]
        public void Spiel_Hinzufügen_Test()
        {
            GameController GC = new GameController();

            GC.Spiel_Hinzufügen("Dark Souls 3");

            Assert.AreEqual(GC.Spiele.Count, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Nicht_Installiertes_Spiel_Hinzufügen()
        {
            GameController GC = new GameController();

            GC.Spiel_Hinzufügen("n.A.");

            Assert.Fail();
        }
    }
}
