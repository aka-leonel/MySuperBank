using System;

namespace MySuperBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount("L.Godoy");
            Console.WriteLine($"Account {myAccount.Number} was created for {myAccount.Owner} with {myAccount.Balance}");
        }
    }
}
