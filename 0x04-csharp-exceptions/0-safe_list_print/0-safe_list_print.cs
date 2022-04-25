using System;
using System.Collections.Generic;

class List
{
	public static int SafePrint(List<int> myList, int n)
	{
		try
		{
			int i = 0;
			for (; i < n; i++)
			{
				Console.WriteLine(myList[i]);
			}
			return (i);
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
