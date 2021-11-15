using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    class Point: Figure
    {
        public Point(string color, bool visible) : base(color, visible, 0, 0)
        {

        }
        public Point(string color, bool visible, int positionX, int positionY): base(color, visible, positionX, positionY)
        {

        }
    }
}
