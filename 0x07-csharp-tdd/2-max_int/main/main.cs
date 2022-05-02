using MyMath;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		List<int> myList1 = new List<int>() { 1, 2, 3, 5, 6, 8, 10};
		Console.WriteLine("Max: " + Operations.Max(myList1));
	}
}
