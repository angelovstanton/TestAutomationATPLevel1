using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsoleApp
{
    public abstract class Animal : IAnimalSound
    {
        protected Animal(string name, int age, bool isFemale)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Invalid input! Name.");
            }

            if (age <= 0 )
            {
                throw new ArgumentException("Invalid input! Age.");
            }


            Name = name;
            Age = age;
            IsFemale = isFemale;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public bool IsFemale { get; private set; }

        public string Gender => this.IsFemale ? "Female" : "Male";

        public abstract string ProductSound();


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine( base.ToString());
            sb.AppendLine($"Name=`{Name}`  Age={Age}  Gender={Gender}");
            sb.AppendLine($"{this.ProductSound()}");
            return sb.ToString();
        }

    }
}
