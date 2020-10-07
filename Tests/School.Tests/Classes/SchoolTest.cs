using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolUTF.Classes;
using System;

namespace SchoolUTF.Tests
{
    [TestClass]
    public class SchoolTest
    {
        private readonly string _uniName = "SofiaU";

        //[ClassInitialize]
        //public static void ClassInitialize(TestContext testContext)
        //{
        //    Console.WriteLine("Execute ClassInitialize");
        //}

        //[TestInitialize]
        //public void TestInit()
        //{
        //    Console.WriteLine("Execute Before Each Test");
        //}

        //[TestCleanup]
        //public void TestCleanup()
        //{
        //    Console.WriteLine("After Each Test");
        //}

        [TestMethod]
        [TestCategory("School")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void CreateEmptyNameSchool()
        {
            School uni = new School("");

            int actual = uni.CourseCount;
            Assert.AreEqual<int>(0, actual);
        }

        [TestMethod]
        [TestCategory("School")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void CreateNullNameSchool()
        {
            School uni = new School(null);

            int actual = uni.CourseCount;
            Assert.AreEqual<int>(0, actual);
        }

        [TestMethod]
        [TestCategory("School")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void AddNoCourse()
        {
            School uni = new School(_uniName);
            uni.AddCourse(null);

            int actual = uni.CourseCount;
            Assert.AreEqual<int>(0, actual);
        }

        [TestMethod]
        [TestCategory("School")]
        public void AddSingleCourse()
        {
            School uni = new School(_uniName);
            Course course = new Course("Automation");
            Student bob = new Student("Bob", Student.MinId);

            course.AddStudent(bob);
            uni.AddCourse(course);

            int actual = uni.CourseCount;
            Assert.AreEqual<int>(1, actual);
        }

        [TestMethod]
        [TestCategory("School")]
        public void AddCourses()
        {
            School uni = new School(_uniName);
            Course courseA = new Course("Automation");
            Course courseB = new Course("Demos");

            int maxCount = 30;
            for (int i = 0; i < maxCount; i++)
            {
                Student bob = new Student("StudentName" + i, Student.MinId + i);
                courseA.AddStudent(bob);

                courseB.AddStudent(bob);
            }

            uni.AddCourse(courseA);
            uni.AddCourse(courseB);

            int actual = uni.CourseCount;
            Assert.AreEqual<int>(2, actual);
        }

        [TestMethod]
        [TestCategory("School")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void AddSameCourses()
        {
            School uni = new School(_uniName);
            Course courseA = new Course("Automation");
            Course courseD = new Course("Automation");
            Student bob = new Student("Bob", Student.MinId);

            courseA.AddStudent(bob);
            courseD.AddStudent(bob);

            uni.AddCourse(courseA);
            uni.AddCourse(courseD);


            int actual = uni.CourseCount;
            Assert.AreEqual<int>(2, actual);
        }      

        [TestMethod]
        [TestCategory("School")]
        public void RemoveSingleCourse()
        {
            School uni = new School(_uniName);
            Course courseA = new Course("Automation");
            Course courseD = new Course("Demos");
            Student bob = new Student("Bob", Student.MinId);

            courseA.AddStudent(bob);
            courseD.AddStudent(bob);

            uni.AddCourse(courseA);
            uni.AddCourse(courseD);

            int actualAdd = uni.CourseCount;
            Assert.AreEqual<int>(2, actualAdd);



            uni.RemoveCourse(courseA);
            int actual = uni.CourseCount;
            Assert.AreEqual<int>(1, actual);
        }

    }
}
