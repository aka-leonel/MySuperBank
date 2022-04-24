using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperBank
{
    internal class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance {
            get
            {
                decimal balance = 0;
                foreach(var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            } 
        }
        private static int accountNumberSeed = 1234;

        private List<Transaction> allTransactions = new List<Transaction>();
        public BankAccount(string name) 
        {
            this.Owner = name;            
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
