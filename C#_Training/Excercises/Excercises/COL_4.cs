using System;
using System.Collections.Generic;
using System.Text;

namespace Excercises
{
    class Program10
    {
        static void Main()
        {
            int i = 0;
            int[] arr = new int[20];
            int[] arr1 = new int[20];
            int n;
            Console.Write("Input the size of array : ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element {0} : ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("List of positive numbers : ");
            int j = 0;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    arr1[j] = arr[i];
                    Console.Write(arr1[j] + ",");
                    j++;
                }
            }
        }
    }
}
