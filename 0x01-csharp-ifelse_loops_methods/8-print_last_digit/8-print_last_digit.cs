using System;

class Number
{
	public static int PrintLastDigit(int number)
	{
		int num = number % 10;

		if (num < 0)
		{
			int numpos = num * -1;
			Console.Write(numpos);
			return (numpos);
		}
		else
		{
			Console.Write(num);
			return (num);
		}

	}
}
