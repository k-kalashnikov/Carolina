using System;
using System.Collections.Generic;

namespace Baisc
{
    class Program
    {
        static void Main(string[] args)
        {
            modifylist();

            static void friends()
            {

                string firstFriend = "Aleks";
                string secondFriend = "Izera";

                Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

                Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
                Console.WriteLine($"The name {secondFriend} had {secondFriend.Length} letters.");
            }

            static void Hello()
            {
                {

                    string greeting = "    Hello World!    ";
                    Console.WriteLine($"[{greeting}]");

                    string trimmedGreeting = greeting.TrimStart();
                    Console.WriteLine($"[{trimmedGreeting}]");

                    trimmedGreeting = greeting.TrimEnd();
                    Console.WriteLine($"[{trimmedGreeting}]");

                    trimmedGreeting = greeting.Trim();
                    Console.WriteLine($"[{trimmedGreeting}]");
                }

                {
                    string sayHello = "Hello World!";
                    Console.WriteLine(sayHello);
                    sayHello = sayHello.Replace("Hello", "Greetings");
                    Console.WriteLine(sayHello);

                    Console.WriteLine(sayHello.ToUpper());
                    Console.WriteLine(sayHello.ToLower());
                }

                {
                    string songLyrics = "You say goodbye, and I say hello";

                    var result1 = songLyrics.Contains("goodbye");

                    Console.WriteLine(result1);
                    Console.WriteLine(songLyrics.Contains("goodbye"));
                    Console.WriteLine(songLyrics.Contains("greetings"));

                    Console.WriteLine(songLyrics.StartsWith("You"));
                    Console.WriteLine(songLyrics.EndsWith("hello"));
                }
            }

            static void Numbers()
            {


                {
                    int a = 7;
                    int b = 4;
                    int c = 3;
                    int d = (a + b) / c;
                    int e = (a + b) % c;
                    Console.WriteLine($"quotient: {d}");
                    Console.WriteLine($"remainder: {e}");
                }

                {
                    int max = int.MaxValue;
                    int min = int.MinValue;
                    Console.WriteLine($"The range of integers is {min} to {max}");

                    int what = max + 3;
                    Console.WriteLine($"An example of overflow: {what}");
                }

                {
                    double a = 5;
                    double b = 4;
                    double c = 2;
                    double d = (a + b) / c;
                    Console.WriteLine(d);

                    double max = double.MaxValue;
                    double min = double.MinValue;
                    Console.WriteLine($"The range of double is {min} to {max}");

                    double third = 1.0 / 3.0;
                    Console.WriteLine(third);
                }

                {
                    decimal min = decimal.MinValue;
                    decimal max = decimal.MaxValue;
                    Console.WriteLine($"The range on the decimal is {min} to {max}");


                    double a = 1.0;
                    double b = 3.0;
                    Console.WriteLine(a / b);

                    decimal c = 1.0M;
                    decimal d = 3.0M;
                    Console.WriteLine(c / d);

                }

                {
                    decimal min1 = decimal.MinValue;
                    decimal max1 = decimal.MaxValue;
                    Console.WriteLine($"The range of the decimak type is {min1} to {max1}");

                    int min2 = int.MinValue;
                    int max2 = int.MaxValue;
                    Console.WriteLine($"The range of the int type is {min2} to {max2}");

                    long min3 = long.MinValue;
                    long max3 = long.MaxValue;
                    Console.WriteLine($"The range of the long type is {min3} to {max3}");

                    short min4 = short.MinValue;
                    short max4 = short.MaxValue;
                    Console.WriteLine($"The range of the short type is {min4} to {max4}");
                }

                {
                    double radius = 3.52;
                    double area = Math.PI * radius * radius;
                    Console.WriteLine($"The circle ares = {area}");
                }
            }

            static void branches()
            {
                int a = 5;
                int b = 6;

                bool something = a + b > 10;

                if (something)
                {
                    Console.WriteLine("The answer is greater than 10.");
                }
                else
                {
                    Console.WriteLine("The answer is not greater than 10");
                }
            }

            static void branches2()
            {
                int a = 5;
                int b = 6;
                int c = 4;

                if ((a + b + c > 10) && (a == b))
                {
                    Console.WriteLine("The answer is greater than 10");
                    Console.WriteLine("And the first number is equal to the second");
                }
                else
                {
                    Console.WriteLine("The answer is not greater than 10");
                    Console.WriteLine("Or the first number is not equal to the second");
                }
            }

            static void branches3()
            {
                int a = 5;
                int b = 6;
                int c = 4;

                if ((a + b + c > 10) || (a == b))
                {
                    Console.WriteLine("The answer is greater than 10");
                    Console.WriteLine("And the first number is equal to the second");
                }
                else
                {
                    Console.WriteLine("The answer is not greater than 10");
                    Console.WriteLine("Or the first number is not equal to the second");
                }
            }

            static void loops()
            {
                int counter = 0;
                do
                {
                    Console.WriteLine($"Hello World! This counter is {counter}");
                    counter++;
                } while (counter < 10);

            }

            static void loops2()
            {
                for (int index = 0; index < 10; index++)
                {
                    Console.WriteLine($"Hello World! The index is {index}");
                }
            }

            static void loops3()
            {
                for (int row = 1; row < 11; row++)
                {
                    Console.WriteLine($"The row is {row}");
                }

                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The coumn is {column}");
                }

                for (int row = 1; row < 11; row++)
                {
                    for (char column = 'a'; column < 'k'; column++)
                    {
                        Console.WriteLine($"The cell is ({row}, {column}");
                    }
                }
            }

            static void loopsandbranches()
            {
                int sum = 0;
                for (int counter = 1; counter < 21; counter++)
                {
                    if (counter % 3 == 0)
                    {
                        sum = sum + counter;
                    }
                }
                Console.WriteLine($"The sum is {sum}");
            }

            static void loopsandbranches2()
            {
                int counter = 1;
                int sum = 0;
                while (counter < 21)
                {
                    if (counter % 3 == 0)
                    {
                        sum = sum + counter;
                        counter++;
                    }
                    else
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"The sum is {sum}");
            }

            static void list()
            {
                var names = new List<string> { "Nikita", "Vika", "Alex", "Izera" };
                foreach (var name in names)
                {
                    Console.WriteLine($"Hello {name.ToUpper()}!");
                }
            }

            static void modifylist()
            {
                var names = new List<string> { "Nikita", "Vika", "Alex", "Izera" };

                names.Add("Maria");
                names.Add("Sasha");
                names.Remove("Nikita");
                foreach (var name in names)
                {
                    Console.WriteLine($" Hello {name.ToUpper()}!");
                }

                Console.WriteLine(names[1]);
            }
        }
    }
}
