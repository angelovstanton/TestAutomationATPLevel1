using NUnit.Framework;

namespace MyFirstNUnitTestProject
{
    [TestFixture]
    public class SecondTestClass
    {
        // Test Initialize
        [SetUp]
        public void TestInit()
        {
            System.Console.WriteLine("Execute TestInit");
        }

        [TearDown]
        public void TearDown()
        {
            System.Console.WriteLine("Execute TestCleanUp");
        }

        // TestMethod
        [Test]
        [Category("Chrome")]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}