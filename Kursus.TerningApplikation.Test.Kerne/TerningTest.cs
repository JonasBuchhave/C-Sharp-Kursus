using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kursus.TerningApplikation.TerningKerne;

namespace Kursus.TerningApplikation.Test.Kerne
{
    [TestClass]
    public class TerningTest
    {
        
        [TestMethod]
        public void OpretTerningTest()
        {
            for (int i = 0; i < 1000; i++)
            {
                Terning t = new Terning();
                int v = t.Værdi;
                Assert.IsTrue(v > 0 && v < 7);
            }
        }
    }
}
