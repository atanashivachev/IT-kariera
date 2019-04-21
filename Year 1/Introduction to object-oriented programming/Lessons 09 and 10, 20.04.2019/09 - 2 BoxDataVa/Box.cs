using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___2_BoxDataVa
{
    class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Volume()
        {
            return length * width * height;
        }

        public double LateralSurfaceArea()
        {
            return (2.0 * length * height) + (2.0 * width * height);
        }

        public double SurfaceArea()
        {
            return (2.0 * length * width) + (2.0 * length * height) + (2.0 * width * height);
        }

        public double Length
        {
            get { return length; }
            set
            {
                if (value < 1)
                { throw new ArgumentException("Length cannot be zero or negative."); }

                length = value;
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value < 1)
                { throw new ArgumentException("Width cannot be zero or negative."); }

                width = value;
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value < 1)
                { throw new ArgumentException("Height cannot be zero or negative."); }

                height = value;
            }
        }
    }
}
