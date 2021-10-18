using System;
using System.Text;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "test";
            Console.WriteLine(test);

            string result = Reverse(test);
            Console.WriteLine(result);

            Console.ReadLine();
        }

        public static string Reverse(string startString)
        {
            StringBuilder result = new StringBuilder();


            for(int i = startString.Length - 1; i >= 0; i--)
            {
                result.Append(startString[i]);
            }

            return result.ToString();
        }
    }
}
