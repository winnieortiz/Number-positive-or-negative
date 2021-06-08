using System;

namespace number_positive_or_negative
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            
            Console.WriteLine("Please enter a number");
            number1 = Convert.ToInt32(Console.ReadLine());

            if(number1 >= 0)
            {
                Console.WriteLine("number is positive");
            }
            else
            {
                Console.WriteLine("number is negative");

            }
        }

    }
}
