using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    class Figure
    {
        private string color;
        private bool visible;
        private int positionX;
        private int positionY;

        public Figure(string color, bool visible): this(color, visible, 0, 0)
        {

        }
        public Figure(string color, bool visible, int positionX, int positionY)
        {
            this.color = color;
            this.visible = visible;
            this.positionX = positionX;
            this.positionY = positionY;
        }

        public void HorizontalMovement(int value)
        {
            positionX += value;
        }

        public void VerticalMovement(int value)
        {
            positionY += value;
        }

        public void ChangeColor(string color)
        {
            this.color = color;
        }

        public bool IsVisible()
        {
            return visible;
        }

        public override string ToString()
        {
            return $"Цвет {color}, видимый {visible}, позиция X {positionX}, позиция Y {positionY}";
        }

    }
}
