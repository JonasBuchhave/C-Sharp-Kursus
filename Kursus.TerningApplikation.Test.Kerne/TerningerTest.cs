using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kursus.TerningApplikation.TerningKerne;

namespace Kursus.TerningApplikation.Test.Kerne
{
    [TestClass]
    public class TerningerTest
    {
        // TODO: Mangler andre tests

        [TestMethod]
        public void OpretTerningerTest()
        {
            var t = new Terninger(6);
            Assert.IsTrue(t.Antal() == 6);
        }

        [TestMethod]
        public void OpretTerningerForkertTest()
        {
            var t = new Terninger(0);
            Assert.IsTrue(t.Antal() == 1);

            t = new Terninger(7);
            Assert.IsTrue(t.Antal() == 1);

        }

    }
}
