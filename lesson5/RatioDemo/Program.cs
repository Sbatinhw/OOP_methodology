using System;
using ComplexusNum;

namespace RatioDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexusDecimal cd1 = new ComplexusDecimal(2, 1);
            ComplexusDecimal cd2 = new ComplexusDecimal(3, 4);

            Console.WriteLine(cd1 * cd2);
            //2+11i
            Console.WriteLine(cd1 + cd2);
            //5+5i
            Console.WriteLine(cd1.Equals(cd2));
            //false

            ComplexusDecimal cd3 = cd1;
            Console.WriteLine(cd1.Equals(cd3));
            //true

            Console.ReadLine();
        }
    }
}
