using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsoleApp
{
    public class Audi : Car, IRepairable, IUpperSpeedLimit
    {
        public Audi(string modelName)
            : base(modelName)
        {
        }

        public int SpeedLimit { get; private set; }

        public void Repair()
        {
            Console.WriteLine("Repair the Audi");
        }

        public void SetUpperSpeedLimit(int speedLimit) => SpeedLimit = speedLimit;
    }
}
