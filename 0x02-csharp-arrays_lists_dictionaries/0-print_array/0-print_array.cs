using System;

class Array
{
	public static int[] CreatePrint(int size)
	{
		int i;
		int[] arr = new int[size];

		if (size > 0)
		{
			for (i = 0; i < size; i++)
			{
				arr[i] = i;
				Console.Write($"{arr[i]} ");
			}
			Console.Write('\n');
			return (arr);
		}
		else if (size == 0)
		{
			Console.Write('\n');
			return (arr);
		}
		else
		{
			Console.WriteLine("Size cannot be negative");
			return null;
		}

	}
}
