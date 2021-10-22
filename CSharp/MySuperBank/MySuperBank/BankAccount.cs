using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperBank
{
    class BankAccount
    {
        public string Number { get; }

        public string Owner { get; set; }

        public decimal Balance { get; }

        private static int accountNumberSeed = 1234567890;

        private List<Transaction> allTransactions;

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

        }
    }
}
