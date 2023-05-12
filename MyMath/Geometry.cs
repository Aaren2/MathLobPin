using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    internal class Geometry
    {
        public static double STriangle(double side, double high)
        {
            return (side * high) / 2;
        }

        public static double SSquare(double side)
        {
            return side * side ;
        }
        public static double SRectangle(double side1, double side2)
        {
            return side1 * side2;
        }

        public static double SRhombus(double diagonal1, double diagonal2)
        {
            return (diagonal1 * diagonal2) / 2;
        }
        public static double SCircle(double radius) 
        {
            return radius * 2 * 3.14;
        }
    }

}
