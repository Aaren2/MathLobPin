using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class Trigonometry
    {
        public static double MySin(double cathetus , double hypotenuse)
        {
            return Math.Round(cathetus / hypotenuse,2);
        }
        public static double MyCos(double cathetus, double hypotenuse)
        {
            return Math.Round(cathetus / hypotenuse,2);
        }
        public static double MyTang(double cathetus1 , double cathetus2)
        {
            return Math.Round(cathetus1 / cathetus2,2);
        }
        public static double MyCoTang(double cathetus1, double cathetus2)
        {
            return Math.Round(cathetus1 / cathetus2, 2);
        }
    }
}
