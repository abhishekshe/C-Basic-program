using System;

namespace Harmonic
{
    class program
    {
        public static void Main()
        {

            Console.WriteLine(GetRemainder(25, 2));
            Console.WriteLine(GetQuotient(24, 2));
        }
        public static int GetRemainder(int dividend, int divisor)
        {
            int result = dividend % divisor;

            return result;

        }
        public static int GetQuotient(int dividend, int divisor)
        {
            int result = dividend / divisor;

            return result;
        }
    }
}