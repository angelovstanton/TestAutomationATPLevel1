using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsoleApp
{
    public class Focus : Car, IRepairable, IUpperSpeedLimit
    {
        public Focus(string modelName)
            : base(modelName)
        {
            SpeedLimit = 140;
        }

        public void Repair()
        {
            Console.WriteLine("Repair the Ford Focus");
        }

        public void SetUpperSpeedLimit(int speedLimit)
        {
            SpeedLimit = speedLimit;
        }

        public override void Describe()
        {
            Console.WriteLine($"Model Name = {ModelName} & Speed Limit = {SpeedLimit}");
        }

        public int SpeedLimit { get; private set; }
    }
}
