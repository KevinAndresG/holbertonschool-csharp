using System;
using System.Collections;
using System.Collections.Generic;

class LList
{
	public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
	{
		myLList.AddFirst(n);
		LinkedListNode<int> newNode = myLList.First;
		return (newNode);
	}
}
