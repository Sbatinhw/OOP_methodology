using System;
using System.Globalization;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "Hello AСoder!";
            ACoder test = new ACoder();

            Console.WriteLine(original);
            Console.WriteLine(test.Encode(original));
            Console.WriteLine(test.Decode(original));
        }
    }
}
