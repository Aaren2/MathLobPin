using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class Geometry
    {
        public static double STriangle(double side, double height)
        {
            return Math.Round((side * height) / 2, 2);
        }

        public static double SSquare(double side)
        {
            return Math.Round(side * side, 2) ;
        }
        public static double SRectangle(double side1, double side2)
        {
            return Math.Round(side1 * side2, 2);
        }

        public static double SRhombus(double diagonal1, double diagonal2)
        {
            return Math.Round((diagonal1 * diagonal2) / 2, 2);
        }
        public static double SCircle(double radius) 
        {
            return Math.Round(radius * 2 * 3.14, 2);
        }
    }

}
