using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    class Rectangle : Point
    {
        private double value1;
        private double value2;
        public Rectangle(double value1, double value2, string color, bool visible) : base(color, visible, 0, 0)
        {
            this.value1 = value1;
            this.value2 = value2;
        }
        public Rectangle(double value1, double value2, string color, bool visible, int positionX, int positionY) : base(color, visible, positionX, positionY)
        {
            this.value1 = value1;
            this.value2 = value2;
        }

        public double CalcArea()
        {
            return value1 * value2;
        }
        public override string ToString()
        {
            return $"{ base.ToString()}, Площадь {CalcArea()}";
        }
    }
}
