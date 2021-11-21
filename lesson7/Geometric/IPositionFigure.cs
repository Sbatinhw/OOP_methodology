using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    interface IPositionFigure
    {
        int X { get; }
        int Y { get; }
        void ChangePosition(int x, int y);
        void ChangePositionX(int x);
        void ChangePositionY(int y);
    }
}
