using System;

namespace School
{
    public class Student
    {
        public Student(string name, int id)
        {
            if (string.IsNullOrEmpty(name) || id < 10000 || id > 99999)
            { 
                throw new ArgumentException("Invalid input");
            }

            Name = name;
            Id = id;
        }

        public string Name { get; set; }
        public int Id { get; set; }
    }
}
