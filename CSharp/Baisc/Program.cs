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
                
            }
        }
    }
}

