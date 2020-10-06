using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsoleApp
{
    public abstract class Cat : Animal
    {
        protected Cat(string name, int age, bool isFemale) 
            : base(name, age, isFemale)
        {
        }

        public override string ProductSound()
        {
            return "MiauMiau";
        }
    }
}
