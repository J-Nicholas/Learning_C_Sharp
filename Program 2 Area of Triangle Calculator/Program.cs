using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_2_Area_of_Triangle_Calculator
{
    // Simple program to read input from user and calculate area of triangle
    class Program
    {
        static void Main(string[] args)
        {
            float area = 0f;
            float baseLength = -1f;
            float heightLength = -1f;
            while(baseLength != 0 || heightLength != 0)
            {
                Console.WriteLine("Welcome to the triangle area calculator.");
                Console.WriteLine("Enter the base followed by a space and then the length measured in cm.");
                var input = Console.ReadLine();
                var splitArray = input.Split(' ');          // input order: Base, Length 
                if (splitArray.Length == 2)
                {
                    if (splitArray[0] == "0" || splitArray[1] == "0")
                    {
                        Console.WriteLine("Exiting.");
                        System.Environment.Exit(1);
                    }
                    else if (float.TryParse(splitArray[0], out baseLength) && 
                        float.TryParse(splitArray[1], out heightLength))
                    {
                        area = (1f / 2f) * baseLength * heightLength;
                        Console.WriteLine("The area is " + area + " cm");
                    }
                    else
                    {
                        Console.WriteLine("Input was not a number, try again.");
                        continue;
                    }
                }
                else if(splitArray.Length == 1 && splitArray[0] == "0")
                {
                    Console.WriteLine("Exiting.");
                    System.Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("Unexpected input, try again.");
                    continue;
                }
            }
        }
    }
}
