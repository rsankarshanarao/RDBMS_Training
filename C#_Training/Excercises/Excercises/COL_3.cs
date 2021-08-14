using System;
using System.Collections.Generic;
using System.Text;

namespace Excercises
{
    public class Program9
    {
        public static void Main()
        {
            int[] arr1 = new int[10];
            int n, i, j, tmp;
            Console.Write("Input the size of array : ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element {0} : ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }
            Console.Write("\nElements of array in ascending order:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
        }
    }
}
