using System;
using System.Collections.Generic;
using System.Text;

namespace Excercises
{
	class Program13
	{
		static bool isMajority(int[] arr,
								int n, int x)
		{
			int i, last_index = 0;

			last_index = (n % 2 == 0) ? n / 2 :
										n / 2 + 1;

			for (i = 0; i < last_index; i++)
			{
				if (arr[i] == x && arr[i + n / 2] == x)
					return true;
			}
			return false;
		}

		public static void Main()
		{
			int[] arr = { 1, 2, 3, 4, 4, 4, 4 };
			int n = arr.Length;
			int x = 4;
			if (isMajority(arr, n, x) == true)
				Console.Write(x + " appears more than " +
								n / 2 + " times");
			else
				Console.Write("The Majorant Does not Exist");
		}
	}
}
