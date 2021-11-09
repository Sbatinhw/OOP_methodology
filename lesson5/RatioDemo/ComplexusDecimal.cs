using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexusNum
{
    class ComplexusDecimal
    {
        private decimal a;
        private decimal b;

        public decimal A
        {
            get { return a; }
        }
        public decimal B
        {
            get { return b; }
        }

        public ComplexusDecimal(decimal a, decimal b)
        {
            this.a = a;
            this.b = b;
        }

        public static ComplexusDecimal operator +(ComplexusDecimal c1, ComplexusDecimal c2)
        {
            return new ComplexusDecimal(c1.a + c2.a, c1.b + c2.b);
        }

        public static ComplexusDecimal operator -(ComplexusDecimal c1, ComplexusDecimal c2)
        {
            return new ComplexusDecimal(c1.a - c2.a, c1.b - c2.b);
        }

        public static ComplexusDecimal operator *(ComplexusDecimal c1, ComplexusDecimal c2)
        {
            return new ComplexusDecimal(c1.a * c2.a - c1.b * c2.b, c1.a * c2.b + c1.b * c2.a);
        }

        public override string ToString()
        {
            return $"{a}+{b}i";
        }
    }
}
