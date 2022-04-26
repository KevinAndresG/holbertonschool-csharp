using System;
using System.Collections.Generic;

class List
{
	public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
	{
		List<int> newList = new List<int>();
		for (int j = 0; j < listLength; j++)
		{
			try
			{
				newList.Add(list1[j] / list2[j]);
			}
			catch (DivideByZeroException)
			{

				Console.WriteLine("Cannot divide by zero");
				newList.Add(0);
			}
			catch (ArgumentOutOfRangeException)
			{
				Console.WriteLine("Out of range");
			}
		}
		return (newList);
	}
}
