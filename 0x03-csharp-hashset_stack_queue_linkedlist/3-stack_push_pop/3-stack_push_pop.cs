using System;
using System.Collections.Generic;

class MyStack
{
	public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
	{
		if (aStack.Count() == 0)
		{
			Console.WriteLine("Stack is empty");
		}
		int stackSize = aStack.Count();
		Stack<string> newStack = new Stack<string>();

		Console.WriteLine($"Number of items: {stackSize}");
		Console.WriteLine($"Top item: {aStack.Peek()}");
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
			aStack.Push(newItem);
		}
		else
		{
			Console.WriteLine($"Stack contains {search}: False");
		}
		return (aStack);
	}
}
