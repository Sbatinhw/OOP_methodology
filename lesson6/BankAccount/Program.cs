using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac1 = new Account();
            Account ac2 = new Account();

            Console.WriteLine($"{ac1.Id} {ac2.Id}");
            Console.WriteLine($"{ac1.Balance} {ac2.Balance}");
            Console.WriteLine($"{ac1.AccountType} {ac2.AccountType}");

            Account ac3 = new Account(1000);

            Console.WriteLine($"{ac3.Id} {ac3.AccountType} {ac3.Balance} баланс должен быть 1000");

            ac3.Withdrawed(1500);

            Console.WriteLine($"{ac3.Id} {ac3.AccountType} {ac3.Balance} баланс должен быть 1000");

            ac3.Added(2000);

            Console.WriteLine($"{ac3.Id} {ac3.AccountType} {ac3.Balance} баланс должен быть 3000");

            ac3.Withdrawed(1000);

            Console.WriteLine($"{ac3.Id} {ac3.AccountType} {ac3.Balance} баланс должен быть 2000");

            ac3.Withdrawed(-1000);

            Console.WriteLine($"{ac3.Id} {ac3.AccountType} {ac3.Balance} баланс должен быть 2000");

            Account ac4 = new Account(-100);

            Console.WriteLine($"{ac4.Id} {ac4.AccountType} {ac4.Balance} баланс должен быть 0");


            Console.ReadLine();
        }
    }
}
