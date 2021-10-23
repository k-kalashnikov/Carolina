using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Nikita", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
        
            account.MakeWithdrawal(50, DateTime.Now, "PC Game");
           
            Console.WriteLine(account.GetAccountHistory());



            //// Test for a negative balance:
            //try
            //{
            //    account.MakeWithdrawal(75000, DateTime.Now, "Attemp to overdraw");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Execption caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}
            //// Test that the initial balances must be positive.
            //try
            //{
            //    var invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negatie balance");
            //    Console.WriteLine(e.ToString());
            //}
        }
    }
}
