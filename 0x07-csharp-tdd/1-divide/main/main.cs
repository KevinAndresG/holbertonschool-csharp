using MyMath;
using System.Collections;

class Program
{
	static void Main()
	{
		int[,] mat = new int[,] { { 4, 5 }, { 3, 1 }, { 3, 8 } };
		int[,] mat2 = MyMath.Matrix.Divide(mat, 2);
		foreach (var item in mat2)
		{
			Console.Write($"{item} ");
		}
	}
}
