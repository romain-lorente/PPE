using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PPE
{
    [TestClass]
    public class Test_Mot
    {
        [TestMethod]
        public void SelectByText_UnMot()
        {
            PPEDataBase.Connexion();

            List<Mot> res = PPEDataBase.Mot.SelectByText("Quentin");
            Assert.AreEqual(1, res.ToArray().Length);
        }

        [TestMethod]
        public void SelectByText_DeuxMots()
        {
            PPEDataBase.Connexion();

            List<Mot> res = PPEDataBase.Mot.SelectByText("marche");
            Assert.AreEqual(2, res.ToArray().Length);
        }
    }
}
