using System;

namespace LeapYear

{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year:");
            int year = int.Parse(Console.ReadLine());
            bool isLeapYear = program.isLeapYear(year);
            if (isLeapYear)
            {
                Console.WriteLine(year + "is a leap year");
            }
            else
            {
                Console.WriteLine(year + "is not a leap year");

            }
        }
        public static bool isLeapYear(int year)
        {
            if ((year % 400 == 0) || (year % 100 != 0 && year % 4 == 0))
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