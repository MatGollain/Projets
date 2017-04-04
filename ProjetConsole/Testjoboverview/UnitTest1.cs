using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace JobOverview
{
    [TestClass]
    public class TestJobOverview
    {
        [TestMethod]
        public void Duréeactivité()
        {
            var a1 = new DAL();
            a1.ChargeFichier();
            int résultat = Results.DuréeTotaleActivité(a1.Data, CodeActivités.ANF, "1.00");
            Assert.AreEqual(295, résultat);
        }
        [TestMethod]
        public void Duréerestante()
        {
            var a1 = new DAL();
            a1.ChargeFichier();
            int résultat = Results.DuréeTravailRestantPersonne(a1.Data, "GL", "2.00");
            Assert.AreEqual(résultat, 21);
        }
        [TestMethod]
        public void Duréeréalisé()
        {
            var a1 = new DAL();
            a1.ChargeFichier();
            int résultat = Results.DuréeTravailRéaliséPersonne(a1.Data, "GL", "2.00");
            Assert.AreEqual(résultat, 58);
        }
        [TestMethod]
        public void Duréeannexe()
        {
            var a2 = new List<Annexes>();
            a2.Add(new Annexes() { LibTache = "Judo", DateAnnexe = DateTime.Today, DuréeTravailRéalisé = 15 });
            a2.Add(new Annexes() { LibTache = "Judo", DateAnnexe = DateTime.Today, DuréeTravailRéalisé = 51 });
            int résultat = Results.DuréeTravailAnnexe(a2, 7, "Judo");
            Assert.AreEqual(résultat, 0);
        }
    }
}