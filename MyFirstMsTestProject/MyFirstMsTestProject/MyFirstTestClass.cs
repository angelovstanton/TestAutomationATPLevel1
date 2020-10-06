using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyFirstMsTestProject
{
    [TestClass]
    public class MyFirstTestClass
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            Console.WriteLine("Execute ClassInitialize");
        }

        [TestInitialize]
        public void TestInit()
        {
            Console.WriteLine("Execute Before Each Test");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Console.WriteLine("After Each Test");
        }

        [TestMethod]
        [TestCategory("Chrome")]
        public void MyFirstTest()
        {
            Console.WriteLine("Execute MyFirstTest");
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [TestCategory("CI")]
        public void SecondTest()
        {
            Console.WriteLine("Execute SecondTest");
            Assert.AreEqual(1, 1);
        }
    }
}
