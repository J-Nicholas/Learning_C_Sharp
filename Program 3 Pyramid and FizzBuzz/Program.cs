using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_3_Pyramid_and_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program that prints out an asterisk pyramid.
            int starCount = 1;
            for (int row = 0; row < 5; row++)                   // This loop controls how many vertical rows there are
            {
                for (int spaces = 0; spaces < 4 - row; spaces++)
                    Console.Write(" ");
                for (int stars = 0; stars < starCount; stars++)
                    Console.Write("*");

                starCount += 2;
                Console.WriteLine();
            }

            // FizzBuzz problem
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
