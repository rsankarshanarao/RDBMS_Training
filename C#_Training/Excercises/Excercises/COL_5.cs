using System;
using System.Collections.Generic;
using System.Text;

namespace Excercises
{
	class Program11
	{
		static int[] getOddOccurrence(int[] arr, int arr_size)
		{
			int[] arr2 = new int[arr_size];
			int index = 0;
			for (int i = 0; i < arr_size; i++)
			{
				int count = 0;

				for (int j = 0; j < arr_size; j++)
				{
					if (arr[i] == arr[j])
						count++;
				}
				if (count % 2 == 0)
                {
					arr2[index] = arr[i];
					index++;
				}	
			}
			return arr2;
		}

		public static void Main()
		{
			int[] arr = { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
			int n = arr.Length;
			int[] arr2 = getOddOccurrence(arr, n);
			for(int i=0; i<arr2.Length; i++)
            {
				Console.Write(arr2[i] + " ,");
            }
		}
	}
}
