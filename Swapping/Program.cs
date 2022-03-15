using System;

namespace program
{
    class Swap
    {
        static void Main()
        {
            int number1 = 10, number2 = 20, temp = 0;
            Console.WriteLine("beore swapping"+" a:="+number1+"  b:="+ number2);



            temp = number1; //temp=10
            number1 = number2; //number1=20      
            number2 = temp; //number2=10    
            Console.WriteLine("After swapping", number1, number2);
            Console.ReadKey();
        }
    }
}
            
        
    


