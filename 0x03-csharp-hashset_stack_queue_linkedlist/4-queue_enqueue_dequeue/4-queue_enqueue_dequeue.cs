using System;
using System.Collections.Generic;
using System.Linq;

class MyQueue
{
	public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
	{
		int queueSize = aQueue.Count();
		Console.WriteLine($"Number of items: {queueSize}");

		if (aQueue.Count() == 0)
		{
			Console.WriteLine("Queue is empty");
		}
		else
		{
			Console.WriteLine($"First item: {aQueue.Peek()}");
		}
		Queue<string> newStack = new Queue<string>();

		if (aQueue.Contains(search))
		{
			string[] i = new string[queueSize];
			int j = 0;
			int k = 0;
			int o = 0;

			Console.WriteLine($"Queue contains \"{search}\": True");
			while (k < queueSize)
			{
				string words = aQueue.Dequeue();
				i[j] = words;
				j++;
				k++;
			}
			while (o < i.Length)
			{
				if (i[o] == search)
				{
					o++;
					while (o < i.Length)
					{
						aQueue.Enqueue(i[o]);
						o++;
					}
					break;
				}
				o++;
			}
		}
		else
		{
			Console.WriteLine($"Queue contains \"{search}\": False");
		}
		aQueue.Enqueue(newItem);
		return (aQueue);
	}
}
