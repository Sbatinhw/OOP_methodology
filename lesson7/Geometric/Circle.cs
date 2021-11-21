using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    class Circle : Point
    {
        private double radius;
        public double Radius{ get { return radius; } }
        public Circle(string color, double radius):
            base(color)
        {
            this.radius = radius;
        }
        public Circle(double radius, string color, int x, int y, bool visible)
            : base(color, x, y, visible)
        {
            this.radius = radius;
        }

        public override double CalcArea()
        {
            return Math.PI * (radius * radius);
        }
    }
}
