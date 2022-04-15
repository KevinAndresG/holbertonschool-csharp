using System;
using System.Collections.Generic;

class LList
{
	public static int Pop(LinkedList<int> myLList)
	{
		if (myLList.Count == 0)
		{
			return (0);
		}
		int j = 0;
		foreach (int i in myLList)
		{
			j = i;
			myLList.RemoveFirst();
			break;
		}
		return (j);
		// Another form:
		// LinkedListNode<int> newNode = myLList.First;
		// myLList.RemoveFirst();
		// return (newNode.Value);
	}
}
