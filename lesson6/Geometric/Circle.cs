using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    class Circle: Point
    {
        private double radius;
        public Circle(double radius, string color, bool visible) : base(color, visible, 0, 0)
        {
            this.radius = radius;
        }
        public Circle(double radius, string color, bool visible, int positionX, int positionY) : base(color, visible, positionX, positionY)
        {
            this.radius = radius;
        }

        public double CalcArea()
        {
            return Math.PI * (radius * radius);
        }
        public override string ToString()
        {
            return $"{ base.ToString()}, Площадь {CalcArea()}";
        }
    }
}
