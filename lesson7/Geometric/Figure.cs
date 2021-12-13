using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    abstract class Figure : IColorFigure, IPositionFigure, IVisibleFigure, IGeometricArea
    {
        private string color;
        private int x;
        private int y;
        private bool visible;
        public string Color { get { return color; } }

        public int X { get { return x; } }

        public int Y { get { return y; } }

        public bool Visible { get { return visible; } }

        public double Area { get { return CalcArea(); } }

        public Figure(
            string color,
            int x,
            int y,
            bool visible)
        {
            this.color = color;
            this.x = x;
            this.y = y;
            this.visible = visible;
        }

        abstract public double CalcArea();

        public void ChangeColorFigure(string color)
        {
            this.color = color;
        }

        public void ChangePosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void ChangePositionX(int x)
        {
            this.x = x;
        }

        public void ChangePositionY(int y)
        {
            this.y = y;
        }

        public void ChangeVisible(bool isVisible)
        {
            this.visible = isVisible;
        }

        public override string ToString()
        {
            return $"Цвет {color}, видимый {visible}, позиция X {X}, позиция Y {Y}, площадь {CalcArea()}";
        }
    }
}
