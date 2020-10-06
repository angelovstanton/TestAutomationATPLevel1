using System;
using System.Collections.Generic;
using System.Text;

namespace School.Classes
{
    public class Course
    {
        public Course(string name)
        {
            this.Name = name;
            Students = new List<Student>();
        }

        private string _name = string.Empty;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty!");
                }
                _name = value;
            }
        }

        private List<Student> Students { get; set; }

        public void AddStudent(Student pupil)
        {
            if (pupil == null)
            {
                throw new ArgumentException("Student cannot be null!");
            }
            if (this.Students.Count > 30)
            {
                throw new ArgumentException("Course is full!");
            }
            this.Students.Add(pupil);
        }
    }
}
