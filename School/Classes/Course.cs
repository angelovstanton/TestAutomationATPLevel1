using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolUTF.Classes
{
    public class Course
    {
        private const int _maxStudents = 30;

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

        internal List<Student> Students { get; set; }

        public void AddStudent(Student pupil)
        {
            if (pupil == null)
            {
                throw new ArgumentException("Student cannot be null!");
            }

            if (this.Students.Count >= _maxStudents)
            {
                throw new ArgumentException($"Course '{this.Name}' is full!");
            }

            //validate this new student does not have same Id as any others in this course
            bool notUniqueID = this.Students.Any(s => s.Id == pupil.Id);
            if (notUniqueID)
            {
                throw new ArgumentException($"Student '{pupil.Name}' Id is not unique for this course '{this.Name}'!");
            }

            this.Students.Add(pupil);
        }

        public void RemoveStudent(Student pupil)
        {
            if (pupil == null)
            {
                throw new ArgumentException("Student cannot be null!");
            }
                        
            this.Students.Remove(pupil);
        }

        public int StudentCount => this.Students.Count;
    }
}
