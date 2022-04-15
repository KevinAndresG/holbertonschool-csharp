using System;
using System.Collections.Generic;

class LList
{
	public static int Sum(LinkedList<int> myLList)
	{
		// int suma = 0;
		// foreach (int i in myLList)
		// {
		// suma += i;
		// }
		// return suma;
		int suma = 0;
		LinkedListNode<int> newNode = myLList.First;
		while (newNode != null)
		{
			suma += newNode.Value;
			newNode = newNode.Next;
		}
		return (suma);
	}
}
