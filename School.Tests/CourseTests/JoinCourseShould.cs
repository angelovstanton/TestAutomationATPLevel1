using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;

namespace FirstMsTestProject
{
    [TestClass]
    public class JoinCourseShould
    {
        [TestMethod]
        public void ThrowArgumentException_When_31StudentsJoined()
        {
            // Arrange
            Course course = new Course();
            for (int i = 0; i < 30; i++)
            {
                course.JoinCourseUpdate(new Student($"Anton{i}", 10000 + i));
            }

            // Act + Assert
            Assert.ThrowsException<ArgumentException>(() => course.JoinCourseUpdate(new Student($"Anton31", 10031)));
        }
    }
}
