using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeProblem
{
    class Cylinder : Circle
    {
        public Cylinder(double height, double diameter) : base(diameter)
        {
            Height = height;
        }

        public double Height
        {
            get;
            set;
        }
    }
}
