using System;

namespace coin
{
    class program
    {
        static void Main(string[] args)
        {
            int Tosses = 100;
            int Heads = 0;
            int Tails = 0;
            while (Tosses > 0)
            {
                Random random = new Random();
                int result = random.Next(0, 2);
                Console.WriteLine(result);
                Console.ReadKey();
                if (result == 0)
                {
                    Heads++;
                }
                else
                {
                    Tails++;
                }

                Console.WriteLine("Number of Heads:" + Heads);
                Console.WriteLine("Number of Tails:" + Tails);
                Tosses--;


            }
            
        
        }
        
    }
}
