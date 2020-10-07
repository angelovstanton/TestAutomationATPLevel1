using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;

namespace FirstMsTestProject
{
    [TestClass]
    public class StudentShould
    {
        [TestMethod]
        public void ThrowArgumentException_When_NameIsEmpty()
        {
            Assert.ThrowsException<ArgumentException>(() => new Student("", 11));
        }

        [TestMethod]
        public void ThrowArgumentException_When_NameIsNull()
        {
            Assert.ThrowsException<ArgumentException>(() => new Student(null, 11));
        }

        [TestMethod]
        public void ThrowArgumentException_When_IdIsBiggerThan99999()
        {
            Assert.ThrowsException<ArgumentException>(() => new Student("Anton", 100000));
        }

        [TestMethod]
        public void NotThrowArgumentException_When_IdIs99999()
        {
            var newStudent = new Student("Anton", 99999);

            Assert.IsNotNull(newStudent);
        }

        [TestMethod]
        public void NotThrowArgumentException_When_Id10000()
        {
            var newStudent = new Student("Anton", 10000);

            Assert.IsNotNull(newStudent);
        }

        [TestMethod]
        public void ThrowArgumentException_When_IdIsLessThan9999()
        {
            Assert.ThrowsException<ArgumentException>(() => new Student("Anton", 9999));
        }
    }
}
