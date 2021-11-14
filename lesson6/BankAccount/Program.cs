using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac1 = new Account();
            Account ac2 = new Account();

            Console.WriteLine(ac1);
            /*Id: 1
              Account Type: debit
              Balance: 0*/
            Console.WriteLine(ac1.GetHashCode());
            //396458285

            ac1.Added(100);

            Console.WriteLine(ac1);
            /*Id: 1
            Account Type: debit
            Balance: 100 */
            Console.WriteLine(ac1.GetHashCode());
            //396458285

            Console.ReadLine();
        }
    }
}
