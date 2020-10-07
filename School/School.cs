using System;
using System.Collections.Generic;
using System.Linq;

namespace School
{
    public class School
    {
        private List<Student> _students;
        private int currentId;

        public School()
        {
            _students = new List<Student>();
            currentId = 10000;
        }

        public void AddStudent(string name)
        {
            if (IsThereAnyStudentWithName(name))
            {
                throw new ArgumentException($"Student with name = {name} already exists.");
            }

            if (_students.Any(student => student.Name.Equals(name)))
            {
                throw new ArgumentException($"Student with name = {name} already exists.");
            }

            Student student = new Student(name, currentId++);
            _students.Add(student);
        }

        private bool IsThereAnyStudentWithName(string name)
        {
            foreach (Student student in _students)
            {
                if (student.Name == name)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
