using System;
using System.Collections.Generic;

class LList
{
	public static LinkedList<int> CreatePrint(int size)
	{
		LinkedList<int> newlist = new LinkedList<int>();
		int i;

		for (i = 0; i < size; i++)
		{
			newlist.AddLast(i);
		}
		foreach (int j in newlist)
		{
			Console.WriteLine(j);
		}
		return (newlist);
	}
}
