using System;

namespace FridgeProblem
{
    public class Fridge
    {
        private double height;
        private double length;
        private double width;

        public double Height { get => height; set => height = value; }
        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }

        //fridge constructor

        public Fridge(double height, double length, double width)
        {
            Height = height;
            Length = length;
            Width = width;
        }

        private bool RectangleSingleCheck(double side1, double side2, double doorwayHeight, double doorwayWidth)
        {
            return side1 <= doorwayHeight && side2 <= doorwayWidth;
        }

        //method for checking if fridge can pass through rectangle 
        public bool GetInCheck(double doorwayHeight, double doorwayWidth)
        {
            var result = RectangleSingleCheck(Height, Length, doorwayHeight, doorwayWidth) ||
                         RectangleSingleCheck(Height, Width, doorwayHeight, doorwayWidth) ||
                         RectangleSingleCheck(Length, Width, doorwayHeight, doorwayWidth) ||
                         RectangleSingleCheck(Length, Height, doorwayHeight, doorwayWidth) ||
                         RectangleSingleCheck(Width, Height, doorwayHeight, doorwayWidth) ||
                         RectangleSingleCheck(Width, Length, doorwayHeight, doorwayWidth);
            return result;
        }

        private bool SideLimit(double side1, double side2, double windowDiameter)
        {
            return side1 < windowDiameter && side2 <= Math.Sqrt(windowDiameter * windowDiameter - side1 * side1);
        }

        //method for checking if fridge can pass through circle
        public bool GetInCheck(double windowDiameter)
        {
            var result = SideLimit(Height, Length, windowDiameter) ||
                         SideLimit(Height, Width, windowDiameter) ||
                         SideLimit(Length, Width, windowDiameter) ||
                         SideLimit(Length, Height, windowDiameter) ||
                         SideLimit(Width, Height, windowDiameter) ||
                         SideLimit(Width, Length, windowDiameter);
            return result;
        }
    }
}