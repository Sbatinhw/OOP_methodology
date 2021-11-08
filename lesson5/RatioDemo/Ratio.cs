using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatioDemo
{
    class Ratio
    {
        private int numerator; //числитель
        private int denominator; //знаменатель

        public int Numerator { get { return numerator; } }
        public int Denominator { get { return denominator; } }

        public Ratio(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public static bool operator ==(Ratio r1, Ratio r2)
        {
            return Compare(r1, r2);
        }

        public static bool operator !=(Ratio r1, Ratio r2)
        {
            return !Compare(r1, r2);
        }

        private static bool Compare(Ratio r1, Ratio r2)
        {
            if (r1.denominator == r2.denominator)
            {
                if (r1.numerator == r2.numerator)
                {
                    return true;
                }
            }
            else
            {
                if ((r1.numerator * r2.denominator) == (r2.numerator * r1.denominator))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
