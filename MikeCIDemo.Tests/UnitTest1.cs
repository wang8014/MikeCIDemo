using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MikeCIDemo;

namespace MikeCIDemo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(30, Default.TestFunktion());
        }
    }
}
