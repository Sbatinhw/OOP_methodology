using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    interface IGeometricArea
    {
        double Area { get; }
        double CalcArea();
    }
}
