using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4_Foreach_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // populate an array with 50 random ints between 0 and 100 
            // determine minimum, maximum and average using a foreach loop
            Random rand = new Random();
            int[] numberArray = new int[50];
            int max;
            int min;
            int sum = 0;
            float average;

            for (int i = 0; i < 50; i++)
            {
                numberArray[i] = rand.Next(-100, 100);
            }
            max = min = numberArray[0];
            
            foreach(int number in numberArray)
            {
                if (number > max)
                    max = number;
                if (number < min)
                    min = number;
                sum += number;
            }
            average = sum / numberArray.Length;
            Console.WriteLine($"The minimum value is {min}\nThe maximum value is {max}\nThe average was {average}");
        }
    }
}
