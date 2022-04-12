using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
		string less = str.Substring(0, 9);
		string threeTimes = string.Concat(Enumerable.Repeat(str, 3));

		Console.WriteLine(threeTimes);
		Console.WriteLine(less);
	}
}
