using System;
using System.Collections.Generic;
class List
{
	public static List<int> CreatePrint(int size)
	{
		if (size < 0)
		{
			Console.WriteLine("Size cannot be negative");
			return (null);
		}
		List<int> lista = new List<int>();
		int i;
		for (i = 0; i < size; i++)
		{
			lista.Add(i);
			Console.Write($"{lista[i]}");
			if (i != size - 1)
			{
				Console.Write(' ');
			}
		}
		Console.WriteLine();
		return (lista);
	}
}
