using System;
using System.Collections.Generic;

class List
{
	public static List<bool> DivisibleBy2(List<int> myList)
	{
		List<bool> x = new List<bool>();

		foreach (int num in myList)
		{
			if (num % 2 == 0)
			{
				x.Add(true);
			}
			else
			{
				x.Add(false);
			}
		}
		return (x);
	}
}
