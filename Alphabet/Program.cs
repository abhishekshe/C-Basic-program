using System;

namespace wovel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an alphabet:");
            string input = Console.ReadLine();
            char alphabet = Convert.ToChar(input);

            switch (alphabet)
            {
                case 'A':
                    
                        Console.WriteLine("wovel");

                        break;
                    
                case 'E':
                    Console.WriteLine("wovel");
                    break;
                case 'I':
                    Console.WriteLine("wovel");
                    break;
                case 'O':
                    Console.WriteLine("wovel");
                    break;
                case 'U':
                    Console.WriteLine("wovel");
                    break;
                default:
                    Console.WriteLine("Not Wovel");
                    break;
            }
        }
    }
}