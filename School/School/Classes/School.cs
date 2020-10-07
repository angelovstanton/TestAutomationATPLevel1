using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolUTF.Classes
{
    public class School
    {
        public School(string name)
        {
            this.Name = name;
            this.Courses = new List<Course>();
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

        private List<Course> Courses { get; set; }

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentException("Course cannot be null!");
            }
                  
            //validate this new course does not have same Name as any others in this school
            bool notUniqueName = this.Courses.Any(c => string.Compare(c.Name, course.Name, true) == 0);
            if (notUniqueName)
            {
                throw new ArgumentException($"Course '{course.Name}' is not unique for this school '{this.Name}'!");
            }

            this.Courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentException("Course cannot be null!");
            }

            this.Courses.Remove(course);
        }

        public int CourseCount => this.Courses.Count;
    }
}
