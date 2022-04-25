using System;
using System.Collections.Generic;

class List
{
	public static int SafePrint(List<int> myList, int n)
	{
		try
		{
			if (n <= myList.Count)
			{
				int i = 0;
				for (; i < n; i++)
				{
					Console.WriteLine(myList[i]);
				}
				return (i);
			}
			throw new ArgumentOutOfRangeException("index parameter is out of range.");
		}
		catch (ArgumentOutOfRangeException)
		{
			int j = 0;
			for (; j < myList.Count; j++)
			{
				Console.WriteLine(myList[j]);
			}
			return (j);
		}
	}
}
