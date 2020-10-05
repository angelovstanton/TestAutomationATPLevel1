using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsoleApp
{
    public class Dog : Animal
    {
        public Dog(string name, int age, bool isFemale) : base(name, age, isFemale)
        {
        }

        public override string ProductSound()
        {
            return "BauBau";
        }
    }
}
