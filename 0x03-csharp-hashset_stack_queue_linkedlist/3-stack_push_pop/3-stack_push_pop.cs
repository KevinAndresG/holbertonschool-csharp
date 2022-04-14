using System;
using System.Collections.Generic;
using System.Linq;

class MyStack
{
	public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
	{
		int stackSize = aStack.Count();
		Console.WriteLine($"Number of items: {stackSize}");

		if (aStack.Count() == 0)
		{
			Console.WriteLine("Stack is empty");
		}
		else
		{
			Console.WriteLine($"Top item: {aStack.Peek()}");
		}
		Stack<string> newStack = new Stack<string>();

		if (aStack.Contains(search))
		{
			string[] i = new string[stackSize];
			int j = 0;

			Console.WriteLine($"Stack contains \"{search}\": True");
			while (aStack.Count() > 0)
			{
				string words = aStack.Pop();

				i[j] = words;
				j++;
			}
			while (i[j - 1] != search)
			{
				aStack.Push(i[j - 1]);
				j--;
			}
		}
		else
		{
			Console.WriteLine($"Stack contains \"{search}\": False");
		}
		aStack.Push(newItem);
		return (aStack);
	}
}
