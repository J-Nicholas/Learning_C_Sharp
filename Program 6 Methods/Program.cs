using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_6_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = GenerateNumbers(10);
            numberArray = ReOrderArray(numberArray);
            PrintArray(numberArray);
            //Console.WriteLine(IterativeFibonacci(24));
            Console.WriteLine("The first 10 elements in the fibonacci sequence are:");
            for (int i = 0; i < 10; i++) Console.Write(RecursiveFibonacci(i+1)+", ");
            Console.WriteLine();
        }
        static int[] GenerateNumbers(int size)
        {
            Random rand = new Random();
            int[] generatedArray = new int[size];
            Console.Write("Generated array: ");
            for (int i = 0; i < generatedArray.Length; i++)
            {
                generatedArray[i] = rand.Next(0, 10);
                Console.Write(generatedArray[i]+ " ");
            }
            Console.Write("\n");
            return generatedArray;
        }
        static int[] ReOrderArray(int[] numArray)
        {
            int[] tempArray = new int [numArray.Length];
            int originalArrayIndex = numArray.Length-1;           // index of last element in array, function counts down from this to reverse order
            for (int i = 0; i < numArray.Length; i++)
            {
                tempArray[i] = numArray[originalArrayIndex];
                if (originalArrayIndex == 0)
                    break;
                else
                    originalArrayIndex--;
            }
            return tempArray;
        }
        static void PrintArray(int[] numArray)
        {
            Console.Write("Reversed array: ");
            foreach (int entry in numArray)
                Console.Write(entry + " ");
            Console.Write("\n");
        }
        static int IterativeFibonacci(int fibIndex)
        {
            if (fibIndex == 1 || fibIndex == 2) return 1;
            else if (fibIndex <= 0)
            {
                Console.WriteLine("Input not valid. Exiting.");
                System.Environment.Exit(1);
            }
            int tempIndex = fibIndex - 1;
            int[] fibArray = new int[fibIndex];
            fibArray[0] = 1;
            fibArray[1] = 1;
            for (int i = 2; i <= tempIndex; i++)
            {
                fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
                if (i == tempIndex) return fibArray[i];
            }
            return fibArray[fibArray.Length - 1];
        }
        static int RecursiveFibonacci(int fibIndex)
        {
            //base case
            if (fibIndex == 1 || fibIndex == 2) return 1;
            else 
            return RecursiveFibonacci(fibIndex-1) + RecursiveFibonacci(fibIndex-2);
        }
    }
}
