using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___2_OverlRect
{
    class Rectangle
    {
        private string id;
        private int height;
        private int width;
        private int xTopLeft;
        private int yTopLeft;

        public bool OverlapsWith(Rectangle rect)
        {
            int xBotRight = xTopLeft + width;
            int yBotLeft = yTopLeft + height;

            if (xBotRight > rect.XTopLeft && yBotLeft > rect.YTopLeft) return true;
            return false;
        }

        public Rectangle(string id, int height, int width, int xTopLeft, int yTopLeft)
        {
            this.id = id;
            this.height = height;
            this.width = width;
            this.xTopLeft = xTopLeft;
            this.yTopLeft = yTopLeft;
        }

        public string Id { get => id; set => id = value; }
        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }
        public int XTopLeft { get => xTopLeft; set => xTopLeft = value; }
        public int YTopLeft { get => yTopLeft; set => yTopLeft = value; }
    }
}
