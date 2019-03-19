using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeProblem
{
    class Cuboid : Rectangle
    {
        public double Length
        {
            get;
            set;
        }
        public Cuboid(double heigth, double length, double width) : base(heigth, width)
        {
            Length = length;
        }
        public Rectangle SearchMinSides()
        {
            double[] minSides = { this.Height, this.Length, this.Width };
            Array.Sort(minSides);
            Rectangle minRectangle = new Rectangle(minSides[0], minSides[1]);
            return minRectangle;
        }
    }
}
