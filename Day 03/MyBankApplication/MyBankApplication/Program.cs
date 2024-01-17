using MyBankApplication;
using System;

namespace MyBankingApplication 
{
    class Program
    {
        public static void Main(string[] args)
        {
            var account = new AddBankAccount("Rahul", 20000);

            Console.WriteLine("Hello, Good Afternoon");

            Console.WriteLine($"You're Account Number: {account.AccNumber}");
            Console.WriteLine($"Welcome {account.User} has the balance of {account.Balance}");

            account.MakeWithdrawal(30000, DateTime.Today, "Watch");

            Console.WriteLine("After your purchase You have your account balance as: "+ account.Balance);
        }
    }
}