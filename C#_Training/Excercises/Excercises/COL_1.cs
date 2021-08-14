using System;
using System.Collections.Generic;
using System.Linq;

namespace Excercises
{
    public class Program7
    {
        public static void Main()
        {
            List<int> sequence = ReadIntegers();
            Console.WriteLine("The sum of the numbers is: " + sequence.Sum());
            Console.WriteLine("The average of the numbers is: " + sequence.Average());
        }

        private static List<int> ReadIntegers()
        {
            Console.WriteLine("Please, enter positive integers and press Enter when finnished. Enter only one per line:");
            List<int> sequence = new List<int>();
            string input = Console.ReadLine();
            while (input != string.Empty)
            {
                int num = -1;
                try
                {
                    num = int.Parse(input);
                    if (num < 0)
                    {
                        Console.WriteLine("You should only enter positive numbers!");
                    }
                    else
                    {
                        sequence.Add(num);
                        Console.WriteLine(input + " successfully added!");
                    }
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Only Integers Accepted!");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("The numbers entered are: " + string.Join(", ", sequence));
            return sequence;
        }
    }
}
