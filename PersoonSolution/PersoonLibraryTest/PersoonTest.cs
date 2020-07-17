using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersoonLibrary;
using System;
using System.Collections.Generic;

namespace PersoonLibraryTest
{
    [TestClass]
    public class PersoonTest
    {
        private Persoon persoon;
        [TestMethod]
        public void EenPersoonKanMeerdereVoornamenHebben()
        {
            Persoon persoon = new Persoon(new List<String>() { "Jan", "Piet", "Kees" });
            Assert.IsTrue(persoon.ToString() == "Jan Piet Kees");
        }
        [TestMethod]
        public void EenPersoonKan1VoornaamHebben()
        {
            Persoon persoon = new Persoon(new List<String>() { "Jan"});
            Assert.IsTrue(persoon.ToString() == "Jan");
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void VoornaamMagNietLeegZijn()
        {
            Persoon persoon = new Persoon(new List<String>() { "Jan", "Piet", "", "Kees" });
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void PersoonKanGeenTweeKeerDezelfdeVoornaamHebben()
        {
            Persoon persoon = new Persoon(new List<String>() { "Jan", "Piet", "Kees", "Jan" });
        }
        [TestMethod]
        public void IedereVoornaamBestaatUitMinstens1Letter()
        {
            Persoon persoon = new Persoon(new List<String>() { "Jan", "P", "Kees" });
            Assert.IsTrue(persoon.ToString() == "Jan P Kees");

        }
    }
}
