using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolUTF.Classes;

namespace SchoolUTF.Tests
{
    [TestClass]
    public class CourseTest
    {
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
        [TestCategory("Course")]
        //[TestProperty("Course", "Create")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void CreateEmptyNameCourse()
        {
            Course course = new Course("");

            int actual = course.StudentCount;
            Assert.AreEqual<int>(0, actual);
        }

        [TestMethod]
        [TestCategory("Course")]
        //[TestProperty("Course", "Create")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void CreateNullNameCourse()
        {
            Course course = new Course(null);

            int actual = course.StudentCount;
            Assert.AreEqual<int>(0, actual);
        }

        [TestMethod]
        [TestCategory("Course")]
        //[TestProperty("Course", "AddStudent")]
        public void AddNoStudent()
        {
            Course course = new Course("Automation");

            int actual = course.StudentCount;
            Assert.AreEqual<int>(0, actual);
        }

        [TestMethod]
        [TestCategory("Course")]
        //[TestProperty("Course", "AddStudent")]
        public void AddSingleStudent()
        {
            Course course = new Course("Automation");
            Student bob = new Student("Bob", Student.MinId);
            course.AddStudent(bob);

            int actual = course.StudentCount;
            Assert.AreEqual<int>(1, actual);
        }

        [TestMethod]
        [TestCategory("Course")]
        //[TestProperty("Course", "AddStudent")]
        public void AddMaxStudents()
        {
            Course course = new Course("Automation");

            int maxCount = 30;
            for (int i = 0; i < maxCount; i++)
            {
                Student bob = new Student("StudentName" + i, Student.MinId + i);
                course.AddStudent(bob);
            }

            int actual = course.StudentCount;
            Assert.AreEqual<int>(maxCount, actual);
        }

        [TestMethod]
        [TestCategory("Course")]
        //[TestProperty("Course", "AddStudent")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OverloadStudents()
        {
            Course course = new Course("Automation");

            int maxCount = 30;
            for (int i = 0; i < maxCount + 1; i++)
            {
                Student bob = new Student("StudentName" + i, Student.MinId + i);
                course.AddStudent(bob);
            }

            int actual = course.StudentCount;
            Assert.AreEqual<int>(maxCount, actual);
        }

        [TestMethod]
        [TestCategory("Course")]
        //[TestProperty("Course", "AddStudent")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void AddSameStudentId()
        {
            Course course = new Course("Automation");
            Student bob = new Student("Bob", Student.MinId);
            Student doug = new Student("Doug", Student.MinId);
            course.AddStudent(bob);
            course.AddStudent(doug);

            int actual = course.StudentCount;
            Assert.AreEqual<int>(2, actual);
        }

        [TestMethod]
        [TestCategory("Course")]
        //[TestProperty("Course", "AddStudent")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void AddNullStudent()
        {
            Course course = new Course("Automation");
            course.AddStudent(null);

            int actual = course.StudentCount;
            Assert.AreEqual<int>(0, actual);
        }

        [TestMethod]
        [TestCategory("Course")]
        //[TestProperty("Course", "RemoveStudent")]
        public void RemoveSingleStudent()
        {
            Course course = new Course("Automation");
            Student bob = new Student("Bob", Student.MinId);
            course.AddStudent(bob);

            int actualAdd = course.StudentCount;
            Assert.AreEqual<int>(1, actualAdd);

            course.RemoveStudent(bob);
            int actual = course.StudentCount;
            Assert.AreEqual<int>(0, actual);
        }

    }
}
