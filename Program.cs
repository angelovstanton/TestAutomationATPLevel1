using System;
using System.Collections.Generic;
using System.Linq;
using FirstConsoleApp.Classes;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // DEMOS: Intro
            ////string textToBePrinted = "Automating the Planet";
            ////textToBePrinted = "Automating " + "the " + "Planet";
            ////textToBePrinted = string.Concat("Automate", " ", "the", " ", "Planet");
            ////Console.Write(textToBePrinted);

            // DEMOS: Data Types
            ////byte centuries = 25;    
            ////ushort years = 2009;
            ////uint days = 840480;
            ////ulong hours = 19536520;
            ////float realNumber = 2.1F;
            ////double preciseRealNumber = 2.1D;

            ////bool isFemale = false;
            ////Console.WriteLine(isFemale);

            ////string firstText = "Automate ";
            ////string secondPart = "Planet";
            ////object resultObject = firstText + secondPart;
            ////string resultText = (string)resultObject;

            ////Console.WriteLine(resultText);

            ////string firstName = "Anton";
            ////string lastName = "Angelov";
            ////int age = 30;
            ////bool isFemale = false;
            ////////Guid id = Guid.NewGuid();
            ////Random random = new Random();
            ////int id = random.Next(38560000, 38569999);
            ////Console.WriteLine(id);

            ////int firstNumber = 5;
            ////int secondNumber = 10;
            ////int temp = firstNumber; // 5
            ////firstNumber = secondNumber; // 10
            ////secondNumber = temp; // 5

            // DEMO: Operators:
            ////int a = 5;
            ////a = a + 1;
            ////a -= 1;
            ////Console.WriteLine(++a);
            ////Console.WriteLine(a);

            ////int[] numbers = new[] { 5, 6, 7, 8, 9};

            ////for (int i = 0; i < numbers.Length; i++)
            ////{

            ////}
            ////Console.Write("Please enter a number to check: ");
            ////string numberString = Console.ReadLine();
            ////int numberToCheck = int.Parse(numberString);

            ////int a = 5;
            ////int b = 10;
            ////int h = 4;
            ////Console.WriteLine(((a + b)/2) * h);
            ////if (numberToCheck > 0)
            ////{
            ////    Console.WriteLine("It is a positive number.");
            ////    Console.WriteLine("this should be executed in the IF too.");
            ////}

            ////Console.WriteLine("It is a negative number.");

            ////switch (numberToCheck)
            ////{
            ////    case 1:
            ////        {
            ////            Console.WriteLine("Monday");
            ////            Console.WriteLine("use curly brackets!");
            ////            break;
            ////        }
            ////    case 2:
            ////        Console.WriteLine("Tuesday");
            ////        break;
            ////    case 3:
            ////        Console.WriteLine("Wednesday");
            ////        break;
            ////    case 4:
            ////        Console.WriteLine("Thursday");
            ////        break;
            ////    case 5:
            ////        Console.WriteLine("Friday");
            ////        break;
            ////    case 6: 
            ////        Console.WriteLine("Saturday"); 
            ////        break;
            ////    case 7: 
            ////        Console.WriteLine("Sunday"); 
            ////        break;
            ////    default: 
            ////        Console.WriteLine("Error!"); 
            ////        break;
            ////}
            ////for (int i = 1; i < 31; i++)
            ////{
            ////    if (i % 7 != 0 && i % 3 != 0)
            ////    {
            ////        Console.WriteLine(i);
            ////    }
            ////}
            // DEMOS: Arrays
            ////int[] myFirstArray = new int[7];
            ////myFirstArray[0] = 78;
            ////myFirstArray[1] = 79;
            ////myFirstArray[2] = 71;
            ////myFirstArray[3] = 7;
            ////myFirstArray[4] = 1;
            ////myFirstArray[5] = 2;
            ////myFirstArray[6] = 3;

            ////for (int i = 0; i < myFirstArray.Length; i++)
            ////{
            ////    myFirstArray[i] += 1;
            ////    Console.WriteLine(myFirstArray[i]);
            ////}

            ////foreach (var number in myFirstArray)
            ////{
            ////    Console.WriteLine(number);
            ////}

            ////var cities = new List<string>
            ////{
            ////    "London",
            ////    "Kiev"
            ////};

            ////cities.Add("Ottawa");
            ////cities.Add("Berlin");

            ////for (int i = 0; i < cities.Count; i++)
            ////{
            ////    Console.WriteLine(cities[i]);
            ////    Console.WriteLine(cities.ElementAt(i));
            ////}

            ////foreach (var city in cities)    
            ////{
            ////    Console.WriteLine(city);
            ////}
            ///

            ////int[] result = InitializeArray(40, 7);
            ////int[] result1 = InitializeArray(20, 2);

            ////int[] numbers = new int[20];
            ////for (int i = 0; i < numbers.Length; i++)
            ////{
            ////    numbers[i] = i * 5;
            ////}

           ////var numList = new List<int>(20);
            ////for (int i = 0; i < 20; i++)
            ////{
            ////    numList.Add(i * 5);
            ////    Console.WriteLine(numList[i]);
            ////}

            ////int result = GetMax(2 + 1, 9);
            ////Console.WriteLine(GetMax(3, 9));
            
            // DEMOS: Classes and Objects
            ////Car car1 = new Car("FORD");

            ////Focus focus = new Focus("FOCUS");
            ////Audi audi = new Audi("AUDI");
            ////focus.Describe();
            ////audi.Describe();

            ////Console.WriteLine(focus.ToString());

            ////Person ivan = new Person("Ivan", 20);
            ////Person george = new Person("george", 21);
            ////Person[] people = new Person[] { ivan, george };

            ////Array.Sort(people);

            ////if (people.Contains(george))
            ////{
            ////    Console.WriteLine();
            ////}
            Book newBook = new Book("My Book Title", "AA", 30.2899787f);
            Console.WriteLine(newBook.ToString());
        }

        static int[] InitializeArray(int elementsCount, int mulFactor)
        {
            int[] numbers = new int[elementsCount];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i * mulFactor;
            }

            return numbers;
        }

        static bool IsPrime(int number)
        {
            if (number == 1)
            {
                return false;
            }

            if (number == 2)
            {
                return true;
            }

            var limit = Math.Ceiling(Math.Sqrt(number));

            for (int i = 2; i <= limit; ++i)  
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static int GetMax(int first = 1, int second = 0)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}