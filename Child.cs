using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsoleApp
{
    public class Child : Person
    {
        public Child(string name, int age) : base(name, age)
        {
        }

        public override int Age
        {
            get => base.Age;
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Child not allowed to be more than 15 years!");
                }
                base.Age = value;
            }
        }
    }
}
