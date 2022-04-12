using System;

class Program
{
	static void Main(string[] args)
	{
		for (char alphabet = 'a'; alphabet <= 'z'; alphabet++)
		{
			if (alphabet != 'e' && alphabet != 'q')
			{
				Console.Write($"{alphabet}");
			}
			else
			{
				continue;
			}
		}
	}
}
