using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolUTF.Classes;
using System;


namespace SchoolUTF.Tests
{
    [TestClass]
    public class StudentTest
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
        [TestCategory("Student")]
        //[TestProperty("Student", "Create")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void CreateEmptyNameCourse()
        {
            Student bob = new Student("", Student.MinId);

            Assert.AreNotEqual<string>("Bob", bob.Name);
        }

        [TestMethod]
        [TestCategory("Student")]
        //[TestProperty("Student", "Create")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void CreateNullNameCourse()
        {
           Student bob = new Student(null, Student.MinId);

            Assert.AreNotEqual<string>("Bob", bob.Name);
        }

        [TestMethod]
        [TestCategory("Student")]
        //[TestProperty("Student", "Create")]
        public void CreateStudent()
        {
            Student bob = new Student("Bob", Student.MinId);

            Assert.AreEqual<string>("Bob", bob.Name);
        } 

        [TestMethod]
        [TestCategory("Student")]
        //[TestProperty("Student", "Create")]
        public void CreateStudentMinId()
        {
            Student bob = new Student("Bob", Student.MinId);
           
            Assert.AreEqual<int>(Student.MinId, bob.Id);
        }

        [TestMethod]
        [TestCategory("Student")]
        //[TestProperty("Student", "Create")]
        public void CreateStudentMaxId()
        {
            Student bob = new Student("Bob", Student.MaxId);

            Assert.AreEqual<int>(Student.MaxId, bob.Id);
        }

        [TestMethod]
        [TestCategory("Student")]
        //[TestProperty("Student", "Create")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void CreateStudentLessMinId()
        {
            Student bob = new Student("Bob", Student.MinId - 1);

            Assert.AreNotEqual<int>(Student.MinId - 1, bob.Id);
        }

        [TestMethod]
        [TestCategory("Student")]
        //[TestProperty("Student", "Create")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void CreateStudentOverMaxId()
        {
            Student bob = new Student("Bob", Student.MaxId + 1);

            Assert.AreNotEqual<int>(Student.MaxId + 1, bob.Id);
        }
    }
}
