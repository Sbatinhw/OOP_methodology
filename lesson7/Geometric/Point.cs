using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    abstract class Point : Figure
    {
        public Point(string color, int x, int y, bool visible) 
            : base(color, x, y, visible)
        { }

        public Point(string color)
            : this(color, 0, 0, true) 
        { }
        
    }
}
