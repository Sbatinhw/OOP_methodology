using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    class Rectangle: Point
    {
        private double sideX;
        private double sideY;
        public double SideX { get { return sideX; } }
        public double SideY { get { return sideY; } }
        public Rectangle(string color, double sideX, double sideY) :
            base(color)
        {
            this.sideX = sideX;
            this.sideY = sideY;
        }
        public Rectangle(double sideX, double sideY, string color, int x, int y, bool visible)
            : base(color, x, y, visible)
        {
            this.sideX = sideX;
            this.sideY = sideY;
        }

        public override double CalcArea()
        {
            return sideX * sideY;
        }
    }
}
