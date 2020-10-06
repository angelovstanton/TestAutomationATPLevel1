using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsoleApp
{
    public class Car
    {
        ////string _modelName;
        public const int YEAR_OF_PRODUCTION = 2020;
        public readonly string MODEL;

        public Car(string modelName)
        {
            ModelName = modelName;
            MODEL = modelName;
        }

        public string ModelName { get; set; }

        public virtual void Describe()
        {
            Console.WriteLine(ModelName);
        }
    }
}
