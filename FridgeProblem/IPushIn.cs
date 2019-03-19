using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeProblem
{
    interface IPushIn
    {
        bool PushInCheck(Cuboid fridge, Rectangle doorway);
        bool PushInCheck(Cylinder fridge, Rectangle doorway);
        bool PushInCheck(Sphere fridge, Rectangle doorway);
        bool PushInCheck(Cuboid fridge, Circle doorway);
        bool PushInCheck(Cylinder fridge, Circle doorway);
        bool PushInCheck(Sphere fridge, Circle doorway);

    }
}
