using System;
using System.Collections.Generic;

class List
{
	public static int Sum(List<int> myList)
	{
		int added = 0;
		foreach (var num in myList.Distinct())
		{
			added += num;
		}
		return (added);
	}
}