using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSixteen
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldContinue = false;
            do
            {
                int[] primeArr =
                    {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97,};

                int numInput = GetNumberInput(primeArr.Length);

                Console.WriteLine($"The number {numInput} prime is {primeArr[numInput - 1]}");
                shouldContinue = Option();
            } while (shouldContinue);
            Console.WriteLine("Goodbye");

        }

        static int GetNumberInput(int maxNumber)
        {
            int number;
            while (true)
            {
                Console.WriteLine($"Which prime number are you looking for?  (Enter 1 - {maxNumber})");
                string input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {
                    if (number > 1 && number <= maxNumber)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That number is out of range.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number");
                }
            }
            return number;
        }

        static bool Option()
        {
            {
                string answer;
                do
                {
                    Console.Write("Would you like to play again?:   Y/N ");
                    answer = Console.ReadLine();
                } while (!(answer.ToLower() == "y" || answer.ToLower() == "n"));
                return (answer == "y");
            }

        }
    }
}
