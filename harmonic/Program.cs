using System;

namespace Harmonic
{
    class program
    {
        public static void Main()
        {
            double value = HarmonicNumber(5);
            Console.WriteLine(value);
        }
        public static double HarmonicNumber(double n)
        {
            double result = 0;
            for (double i = 1; i <= n; i++)
            {
                result = result + (1 / i);
            }
            return result;
        }
    }
   
}