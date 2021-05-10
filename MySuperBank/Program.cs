using System;
using BankyStuffLibrary;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var account = new BankAccount("Ram", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with 10000");
            account.MakeWithdrawal(40, DateTime.Now, "cookies");
            account.MakeWithdrawal(110, DateTime.Now, "snacks");
            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
