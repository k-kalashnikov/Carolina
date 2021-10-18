using System;

namespace Baisc
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstFriend = "Aleks";
            string secondFriend = "Izera";

            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            Console.WriteLine($"The name {secondFriend} had {secondFriend.Length} letters.");
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


        }
    }
}

