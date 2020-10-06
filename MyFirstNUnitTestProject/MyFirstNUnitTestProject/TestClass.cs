using NUnit.Framework;

////[assembly: Parallelizable(ParallelScope.Fixtures)]
////[assembly:LevelOfParallelism(3)]

namespace MyFirstNUnitTestProject
{
    [TestFixture]
    public class TestClass
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