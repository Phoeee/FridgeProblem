using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeProblem
{
    class FridgePushIn : IPushIn
    {
        public bool PushInCheck(Cuboid fridge, Rectangle doorway)
        {
            Rectangle fridgeMinSides = fridge.SearchMinSides();
            if ((fridgeMinSides.Height <= doorway.Height && fridgeMinSides.Width <= doorway.Width) ||
               (fridgeMinSides.Height <= doorway.Width && fridgeMinSides.Width <= doorway.Height))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PushInCheck(Cylinder fridge, Rectangle doorway)
        {
            Sphere sphereFridge = new Sphere(fridge.Diameter);
            if ((fridge.Height <= doorway.Height && fridge.Diameter <= doorway.Width) ||
               (fridge.Height <= doorway.Height && fridge.Diameter <= doorway.Width) ||
                (PushInCheck(sphereFridge, doorway)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PushInCheck(Sphere fridge, Rectangle doorway)
        {
            if (fridge.Diameter <= Math.Min(doorway.Height, doorway.Width))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PushInCheck(Cuboid fridge, Circle doorway)
        {
            Rectangle fridgeMinSides = fridge.SearchMinSides();
            if ((Math.Pow(fridgeMinSides.Height, 2) + Math.Pow(fridgeMinSides.Width, 2)) <= doorway.Diameter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PushInCheck(Cylinder fridge, Circle doorway)
        {
            Sphere sphereFridge = new Sphere(fridge.Diameter);
            if ((Math.Pow(fridge.Height, 2) + Math.Pow(fridge.Diameter, 2) <= doorway.Diameter) ||
               PushInCheck(sphereFridge, doorway))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PushInCheck(Sphere fridge, Circle doorway)
        {
            if (fridge.Diameter <= doorway.Diameter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
