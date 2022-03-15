using System;

namespace PowerOf2
{
    class program
    {
        public static void Main()
        {
            int value=PowerOf2(4);
            Console.WriteLine(value);
        }
        public static int PowerOf2(int power)
        {
            int result = 1;
            while (power > 0)
            {
                result = result * 2;
                power--;
            }
            return result;

        }
    }
}