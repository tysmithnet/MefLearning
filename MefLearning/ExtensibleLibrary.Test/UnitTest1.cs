using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensibleLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 c1 = new Class1();
            Assert.AreEqual("hello world", c1.Go());
        }
    }
}
