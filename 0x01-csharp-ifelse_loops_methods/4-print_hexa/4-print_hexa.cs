using System;

class Program
{
	static void Main(string[] args)
	{
		for (int i = 0; i <= 98; i++)
		{
			string hex = Convert.ToString(i, 16);
			Console.WriteLine($"{i} = 0x{hex}");
		}
	}
}
