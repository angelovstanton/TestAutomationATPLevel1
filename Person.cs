using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace FirstConsoleApp
{
    public class Person : IEquatable<Person>, IComparable<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        int _age = 0;
        public virtual int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Person not allowed to have negative age!");
                }
                _age = value;
            }
        }
        public string Name { get; set; }

        public Guid ID { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} Name={Name} Age={Age}";
        }


        public bool Equals([AllowNull] Person other)
        {
            return (this.ID == other.ID);
        }

        public int CompareTo([AllowNull] Person other)
        {
            return this.Age.CompareTo(other.Age);
        }
    }
}
