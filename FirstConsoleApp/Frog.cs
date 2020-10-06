using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsoleApp
{
    public class Frog : Animal
    {
        public Frog(string name, int age, bool isFemale) : base(name, age, isFemale)
        {
        }

        public override string ProductSound()
        {
            return "Frogggg";
        }
    }
}
