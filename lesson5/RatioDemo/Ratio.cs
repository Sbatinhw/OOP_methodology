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
    }
}
