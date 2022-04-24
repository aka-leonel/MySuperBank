using System;

namespace MySuperBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Kendra", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with ${account.Balance}");
            
            account.MakeWithdrawal(120, DateTime.Now, "Hammcok");
            account.MakeWithdrawal(50, DateTime.Now, "Xbox game");

            Console.WriteLine(account.GetAccountHistory());


            //test
            //try
            //{
            //    var invalidAccount = new BankAccount("invalid", -3);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with neagtive balance");
            //    Console.WriteLine(e.ToString());
            //}

            
            Console.WriteLine(account.Balance);

        }
    }
}
