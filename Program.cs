using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args) 
        {
            //int result = 2;
            //string msg = $"automatic{result} {result+200} {result+2000} ";
            //Console.WriteLine(msg);
            //msg = "sheir";
            //Console.WriteLine(msg);

            //msg = DateTime.Now.ToString();
            //Console.WriteLine(msg);

            //msg = Math.Sqrt(32346).ToString();
            //Console.WriteLine(msg);

            //msg = (32346 * 32346).ToString();
            //Console.WriteLine(msg);

            //byte vbyte = 87;
            //sbyte vsbyte = -113;
            //short vshort = -113;
            //ushort vushort =87;
            //int vint = -2000;
            //uint vunit = 51240;
            //long vlong = 4735941;
            //ulong vulong = 4735941;

            //bool isFemale = false;
            //Console.WriteLine(isFemale);

            //string sHi = "Hello";
            //string sWorld = "World";

            //object oVar = sHi + " " + sWorld;
            //string sResult = (string)oVar;
            //Console.WriteLine(sResult);

            //int var1 = 5;
            //int var2 = 10;

            //int var3 = var2;
            //var2 = var1;
            //var1 = var3;
            //Console.WriteLine(var1);
            //Console.WriteLine(var2);

            //Random rand = new Random();
            //int id = rand.Next(38560000, 38569999);
            //Console.WriteLine(id);


            //exercise 4
            //int value = 5;
            //bool isEven = (value % 2) == 0;
            //Console.WriteLine($"value {value}  isEven = {isEven}");

            //int width = 5;
            //int height = 6;
            //int area = width * height;
            //Console.WriteLine($"width {width}  height {height} area = {area}");

            //int value2 = 37;
            //bool isprime = IsPrimeNumber(value2);
            //Console.WriteLine($"is {value2} prime = {isprime}");

            //int sideA = 4;
            //int sideB = 3;
            //area = (sideA + sideB) * height / 2; //trapezoid
            //Console.WriteLine($"sideA {sideA} sideB {sideB}  height {height} area = {area}");


            //exercise 5
            //int valueA = 5;
            //int valueB = 3;
            //if (valueA > valueB)
            //{
            //    int temp = valueB;
            //    valueB = valueA;
            //    valueA = temp;
            //}
            //Console.WriteLine($"valueA {valueA} valueB {valueB}");

            //int prod1 = -5;
            //int prod2 = 7;
            //int prod3 = -9;
            //if (prod1 < 0)
            //{
            //    Console.WriteLine($"prod1 {prod1} is negative");
            //}
            //else
            //{
            //    Console.WriteLine($"prod1 {prod1} is positive");
            //}

            //if (prod2 < 0)
            //{
            //    Console.WriteLine($"prod2 {prod2} is negative");
            //}
            //else
            //{
            //    Console.WriteLine($"prod2 {prod2} is positive");
            //}
            //if (prod3 < 0)
            //{
            //    Console.WriteLine($"prod3 {prod3} is negative");
            //}
            //else
            //{
            //    Console.WriteLine($"prod3 {prod3} is positive");
            //}


            //Day 2 - Exercises 1
            //for (int i = 0; i <= 30; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i <= 30; i++)
            //{
            //    if ((i % 3 != 0) && (i % 7 != 0))
            //    {
            //        Console.WriteLine(i);
            //    }               
            //}

            //Day 2 - Exercises 2
            //int[] numbers = new int[21];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = i * 5;
            //    Console.WriteLine(numbers[i]);
            //}

            //Console.WriteLine("With LIST");
            //List<int> lstInts = new List<int>();
            //for (int i = 0; i < 21; i++)
            //{
            //    lstInts.Add(i * 5);
            //}
            //foreach (int item in lstInts)
            //{
            //    Console.WriteLine(item);
            //}

            ////Day 2 - Exercises 3
            //int firstValue = 7, secondValue = 23;
            //int result = GetMax(firstValue, secondValue);
            //Console.WriteLine($"GetMax({firstValue}, {secondValue}) == {result}");


            //Day 3   - Exercises
            //Random rand = new Random();
            //for (int i = 1; i < 11; i++)
            //{
            //    int id = rand.Next(1, 10);
            //    Console.WriteLine(id);
            //}

            //Day 3 - Person
            //Person Jack = new Person("Jack", 8);
            //Console.WriteLine(Jack);//FirstConsoleApp.Person Name=Jack Age=8
            //Jack.ID = Guid.Empty;

            //Child Jill = new Child("Jill", 11);
            //Console.WriteLine(Jill);//FirstConsoleApp.Child Name=Jill Age=11
            //Jill.ID = Guid.Empty;

            //Console.WriteLine(Jack == Jill); //false
            //Console.WriteLine(Jack.Equals(Jill)); //true

            //Jill.ID = Guid.NewGuid();
            //Console.WriteLine(Jack.Equals(Jill)); //false

            //Console.WriteLine(Jack.Age.CompareTo(Jill.Age)); //-1

            //Jill.Age = Jack.Age;
            //Console.WriteLine(Jack.Age.CompareTo(Jill.Age)); //0


            //Day 3 - Book
            //Book qa = new Book("QA course", "AA", 1.25F);
            //Console.WriteLine(qa);

            //GoldenEditionBook autoQA = new GoldenEditionBook("Automation course", "Anton A", 900.50F);
            //Console.WriteLine(autoQA);

            //Day 3 - Animals
            List<Animal> zoo = new List<Animal>();
            zoo.Add(new Dog("Rufus", 3, true));
            zoo.Add(new Frog("PepeLeFrog", 1, false));
            zoo.Add(new Kitten("Lucie", 4) );
            zoo.Add(new Tomcat("Herc", 2));

            foreach (var pet in zoo)
            {
                Console.WriteLine(pet);
            }
        }

        public static bool IsPrimeNumber(long number)
        {
            if (number <= 1)
                return false;
            else if (number % 2 == 0)
                return number == 2;

            long N = (long)(Math.Sqrt(number) + 0.5);

            for (int i = 3; i <= N; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        public static int GetMax(int first=1, int second=0)
        {
            return (first > second) ? first : second;
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string FamilyName { get; set; }

        public int Age { get; set; }

        public char Gender { get; set; }
        public bool IsFemale { get { return this.Gender == 'f'; } }

        public Guid IDNumber { get; set; }
    }
}
