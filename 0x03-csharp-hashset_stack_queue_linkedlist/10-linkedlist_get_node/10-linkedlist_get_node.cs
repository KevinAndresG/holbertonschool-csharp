using System;
using System.Collections.Generic;
class LList
{
	public static int GetNode(LinkedList<int> myLList, int n)
	{
		int i = 0;
		if (n < myLList.Count || n > 0)
		{
			foreach (int j in myLList)
			{
				if (i == n)
				{
					return (j);
				}
				i++;
			}
		}
		return (0);
	}
}
