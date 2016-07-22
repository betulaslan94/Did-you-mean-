using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Did_you_mean;

namespace DidyoumeanTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Did_you_mean.Form1 f = new Form1();
            int sonuc = f.kelimebul("AAL");
            Assert.AreEqual(1, sonuc);

        }
    }
}
