using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsoleApp
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age) : base (name, age, true)
        {
            
        }

        //public Kitten(string name, int age, bool isFemale) : base(name, age, isFemale)
        //{
        //}

        public override string ProductSound()
        {
            return "Miau";
        }
    }
}
