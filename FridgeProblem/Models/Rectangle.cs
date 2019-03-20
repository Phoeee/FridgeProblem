using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeProblem
{
    class Rectangle
    {
        public double Height
        {
            get;
            set;
        }
        public double Width
        {
            get;
            set;
        }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
    }
}
