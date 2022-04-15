using System;
using System.Collections.Generic;

class LList
{
	public static int FindNode(LinkedList<int> myLList, int value)
	{
		int counter = 0;
		if (myLList.Contains(value))
		{
			foreach (int j in myLList)
			{
				if (j != value)
				{
					counter++;
				}
				else
				{
					return (counter);
				}

			}
		}
		return (-1);
	}
}
