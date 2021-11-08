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

        public static bool operator >(Ratio r1, Ratio r2)
        {
            return FirstMoreSecond(r1, r2);
        }

        public static bool operator <(Ratio r1, Ratio r2)
        {
            return !FirstMoreSecond(r1, r2);
        }

        public static bool operator >=(Ratio r1, Ratio r2)
        {
            return FirstMoreSecond(r1, r2) || Compare(r1, r2);
        }

        public static bool operator <=(Ratio r1, Ratio r2)
        {
            return !FirstMoreSecond(r1, r2) || Compare(r1, r2);
        }

        public static Ratio operator +(Ratio r1, Ratio r2)
        {
            return Addition(r1, r2);
        }

        public static Ratio operator -(Ratio r1, Ratio r2)
        {
            return Subtraction(r1, r2);
        }

        public static Ratio operator ++(Ratio ratio)
        {
            return new Ratio(ratio.numerator + ratio.denominator, ratio.denominator);
        }

        public static Ratio operator --(Ratio ratio)
        {
            return new Ratio(ratio.numerator - ratio.denominator, ratio.denominator);
        }

        public override bool Equals(object obj)
        {
            try 
            {
                Ratio r = (Ratio)obj;
                return Compare(this, r);
            }
            catch
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{numerator} / {denominator}";
        }

        private static Ratio Addition(Ratio r1, Ratio r2)
        {
            if (r1 == null || r2 == null)
            {
                return default;
            }

            if (r1.denominator == r2.denominator)
            {
                return new Ratio(r1.numerator + r2.numerator, r1.denominator);
            }
            else
            {
                return new Ratio((r1.numerator * r2.denominator) + (r2.numerator * r1.denominator), r1.denominator * r2.denominator);
            }
        }

        private static Ratio Subtraction(Ratio r1, Ratio r2)
        {
            if (r1 == null || r2 == null)
            {
                return default;
            }

            if (r1.denominator == r2.denominator)
            {
                return new Ratio(r1.numerator - r2.numerator, r1.denominator);
            }
            else
            {
                return new Ratio((r1.numerator * r2.denominator) - (r2.numerator * r1.denominator), r1.denominator * r2.denominator);
            }
        }

        private static bool FirstMoreSecond(Ratio first, Ratio second)
        {
            if (first == null || second == null)
            {
                return false;
            }

            if (first.denominator == second.denominator)
            {
                if (first.numerator > second.numerator)
                {
                    return true;
                }
            }
            else
            {
                if ((first.numerator * second.denominator) > (second.numerator * first.denominator))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool Compare(Ratio r1, Ratio r2)
        {
            if (r1 == null || r2 == null)
            {
                return false;
            }

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
