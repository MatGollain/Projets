using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JobOverview
{
    [TestClass]
    public class TestJobOverview
    {
        [TestMethod]
        public void Duréeactivité()
        {
            var a1 = new DAL();
            int résultat= Results.DuréeTotaleActivité(a1.Data, CodeActivités.ANF,"1.00");
            Assert.AreEqual(résultat, 295);
        }
    }
}
