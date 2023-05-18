using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class Algebra
    {
        public static double MySum(double[] doubles)
        {
            double sum = 0;
            for (int i = 0; i < doubles.Length; i++) 
            {
                sum += doubles[i];
            }
            return Math.Round(sum, 2);
        }


        public static double MyMax(double[] doubles)
        {
            double max = doubles[0];
            for (int i = 1; i < doubles.Length; i++) 
            {
                if (max < doubles[i])
                {
                    max = doubles[i];
                }
            }
            return Math.Round(max, 2);
        }
        public static double MyMin(double[] doubles)
        {
            double min = doubles[0];
            for (int i = 1; i < doubles.Length; i++)
            {
                if (min > doubles[i])
                {
                    min = doubles[i];
                }
            }
            return Math.Round(min,2);
        }

        public static double MyAvg(double[] doubles)
        {
            double avg = 0;
            for (int i = 0; i < doubles.Length; i++)
            {
                avg += doubles[i];
            }
            return Math.Round(avg / doubles.Length,2);
        }


    }

    
}
