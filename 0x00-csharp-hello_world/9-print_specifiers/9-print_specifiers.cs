using System;
using System.Globalization;
class Program
{
	static void Main(string[] args)
	{
		CultureInfo target = CultureInfo.CreateSpecificCulture("en-US.utf-8");
		double percent = .7553;
		double currency = -98765.4321;
		Console.WriteLine($"Percent: {String.Format(target, "{0:P}", percent)}\nCurrency: {String.Format(target, "{0:C}", currency)}");
	}
}