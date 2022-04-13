using System;
class Program
{
	static void Main(string[] args)
	{
		for (int i = 0; i <= 98; i++)
		{
			string decimalNumber = i.ToString();
			int number = int.Parse(decimalNumber);
			string hex = number.ToString("x");
			Console.Write($"{i} = 0x{hex}\r\n");
		}
	}
}
