using MyMath;
using System;

class Program
{
    static void Main()
    {
        MyMath.Operations Trying;
		Trying = new MyMath.Operations();
        Console.WriteLine("Trying is {0}", Trying.Add(5, 5));
    }
}
