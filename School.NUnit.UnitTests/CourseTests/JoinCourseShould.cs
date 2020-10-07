using System;
using NUnit.Framework;
using School;
using School.NUnit.UnitTests.Factories;

namespace FirstMsTestProject
{
    [TestFixture]
    public class JoinCourseShould
    {
        [Test]
        public void ThrowArgumentException_When_31StudentsJoined()
        {
            // Arrange
            Course course = CourseFactory.CreatePopulatedCourse();

            // Act + Assert
            Assert.Throws<ArgumentException>(() => course.JoinCourseUpdate(new Student($"Anton31", 10031)));
        }
    }
}
