using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolUTF.Classes
{
    public class Student
    {
        private static readonly int _minId = 10000;
        private static readonly int _maxId = 99999;

        public Student(string name, int id)
        {
            Name = name;
            Id = id;
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

        int _studentId = 0;
        public int Id
        {
            get
            {
                return _studentId;
            }
            set
            {

                if (value < _minId || value > _maxId)
                {
                    throw new ArgumentException($"Id must be between {_minId} and {_maxId}");
                }

                _studentId = value;
            }
        }

        public static int MinId => _minId;
        public static int MaxId => _maxId;
    }
}
