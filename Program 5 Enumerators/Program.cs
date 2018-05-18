using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_5_Enumerators
{
    public enum Months  {January = 1, February, March, April, May, June,
        July, August, September, October, November, December};

    class Program
    {
        static void Main(string[] args)
        {
            //This program gets a number from the user and then prints out the corresponding month
            Console.WriteLine("Welcome to the enum program. Enter a number between 1 and 12.");
            Months userMonth;
            int input = -1;
            while (input != 0)
            {
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if (input > 0 && input < 13)
                    {
                        userMonth = (Months)input;
                        switch (userMonth)
                        {
                            case Months.January:
                                Console.WriteLine(Months.January);
                                break;
                            case Months.February:
                                Console.WriteLine(Months.February);
                                break;
                            case Months.March:
                                Console.WriteLine(Months.March);
                                break;
                            case Months.April:
                                Console.WriteLine(Months.April);
                                break;
                            case Months.May:
                                Console.WriteLine(Months.May);
                                break;
                            case Months.June:
                                Console.WriteLine(Months.June);
                                break;
                            case Months.July:
                                Console.WriteLine(Months.July);
                                break;
                            case Months.August:
                                Console.WriteLine(Months.August);
                                break;
                            case Months.September:
                                Console.WriteLine(Months.September);
                                break;
                            case Months.October:
                                Console.WriteLine(Months.October);
                                break;
                            case Months.November:
                                Console.WriteLine(Months.November);
                                break;
                            case Months.December:
                                Console.WriteLine(Months.December);
                                break;
                            default:
                                Console.WriteLine("What month is that?");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Number not in range. Try again.");
                        input = -1;
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                    input = -1;
                    continue;
                }
            }
        }
    }
}
