using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsoleApp
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age) 
            : base(name, age, false)
        {
        }

        public override string ProductSound()
        {
            return "roar";
        }
    }
}
