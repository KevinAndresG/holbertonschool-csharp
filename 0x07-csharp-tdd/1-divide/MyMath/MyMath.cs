using System;

namespace MyMath
{
	public class Matrix
	{
		public static int[,] Divide(int[,] matrix, int num)
		{
			if (matrix == null)
			{
				return (null);
			}
			int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

			try
			{
				for (int i = 0; i < matrix.GetLength(0); i++)
				{
					for (int j = 0; j < matrix.GetLength(1); j++)
					{
						newMatrix[i, j] = matrix[i, j] / num;
					}
				}
				Console.WriteLine(newMatrix.GetType());
				return (newMatrix);
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("Num cannot be 0");
				return (null);
			}
		}
	}
}
