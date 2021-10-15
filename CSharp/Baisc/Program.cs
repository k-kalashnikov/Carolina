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
        }
    }
}

