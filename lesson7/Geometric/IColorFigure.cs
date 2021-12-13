using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    interface IColorFigure
    {
        string Color { get; }
        void ChangeColorFigure(string color);
    }
}
