using System;
using NUnit.Framework;
using School;

namespace FirstMsTestProject
{
    [TestFixture]
    public class StudentShould
    {
        [Test]
        public void ThrowArgumentException_When_NameIsEmpty()
        {
            Assert.Throws<ArgumentException>(() => new Student("", 11));
        }

        [Test]
        public void ThrowArgumentException_When_NameIsNull()
        {
            Assert.Throws<ArgumentException>(() => new Student(null, 11));
        }

        [Test]
        public void ThrowArgumentException_When_IdIsBiggerThan99999()
        {
            Assert.Throws<ArgumentException>(() => new Student("Anton", 100000));
        }

        [Test]
        public void NotThrowArgumentException_When_IdIs99999()
        {
            var newStudent = new Student("Anton", 99999);

            Assert.IsNotNull(newStudent);
        }

        [Test]
        public void NotThrowArgumentException_When_Id10000()
        {
            var newStudent = new Student("Anton", 10000);

            Assert.IsNotNull(newStudent);
        }

        [Test]
        public void ThrowArgumentException_When_IdIsLessThan9999()
        {
            Assert.Throws<ArgumentException>(() => new Student("Anton", 9999));
        }
    }
}
