using System;
using System.Collections.Generic;
using System.Linq;

namespace School
{
    public class Course
    {
        private List<Student> _studentsUpdatedName = new List<Student>();

        public void JoinCourseUpdate(Student student)
        {
            if (_studentsUpdatedName.Count >= 30)
            {
                throw new ArgumentException("No more students are allowed to join. Update");
            }

            _studentsUpdatedName.Add(student);
        }

        public void LeaveCourse(string name)
        {
            if (!_studentsUpdatedName.Any(x => x.Name.Equals(name)))
            {
                throw new ArgumentException($"Student with name = {name} cannot be found. 12345");
            }

            _studentsUpdatedName.Remove(_studentsUpdatedName.First(student => student.Name.Equals(name)));
        }
    }
}
