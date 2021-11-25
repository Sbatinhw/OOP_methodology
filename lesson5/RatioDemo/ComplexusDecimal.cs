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
            string sym = "+";
            if(b < 0)
            {
                sym = "-";
            }
            string result = $"{a}{sym}{b}i";
            return result;
        }

        public override bool Equals(object obj)
        {
            ComplexusDecimal complexus;

            if (this == null || obj == null) { return false; }

            try
            {
                complexus = (ComplexusDecimal)obj;
            }
            catch
            {
                return false;
            }

            if(this.a == complexus.a && this.b == complexus.b)
            {
                return true;
            }

            return false;
        }
    }
}
