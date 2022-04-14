using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
		// string threeTimes = String.Concat(Enumerable.Repeat(str, 3));
		string less = str.Substring(0, 9);
		Console.WriteLine("{0}{0}{0}", str);
		Console.WriteLine($"{less}");
	}
}
