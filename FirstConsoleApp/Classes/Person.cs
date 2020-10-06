using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace FirstConsoleApp.Classes
{
    public class Person : IEquatable<Person>, IComparable<Person>
    {
        public Person(string name, int age)
        {
            if (age <= 0)
            {
                throw new ArgumentException("The age cannot be less than or equal to 0.");
            }

            Name = name;
            Age = age;
            Id = Guid.NewGuid();
        }

        public string Name { get; set; }
        public virtual int Age { get; set; }
        public Guid Id { get; set; }

        public int CompareTo(Person other)
        {
            return Age.CompareTo(other.Age);
        }

        public bool Equals(Person other)
        {
            return Id.Equals(other.Id);
        }

        public override string ToString()
        {
            ////return string.Format("Model Name = {0}, Age = {1}", Name, Age);
            return $"Model Name = {Name}, Age = {Age}";
        }
    }
}
