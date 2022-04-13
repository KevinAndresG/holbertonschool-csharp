using System;

class Program
{
	static void Main(string[] args)
	{
		for (int i = 0; i < 9; i++)
		{
			for (int j = i; j <= 9; j++)
			{
				if (i == 8 && j == 9)
				{
					Console.Write($"{i}{j}\n");
				}
				else if (i != j)
				{
					Console.Write($"{i}{j}, ");
				}
			}
		}
	}
}
