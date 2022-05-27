using System;

class Program
{
    static void Main()
    {
        double[,] matrix = { { -4, 9, 0 }, { 1, -2, 1 }, { 3, -4, 2 } };
        double matrix1 = MatrixMath.Determinant(matrix);
        Console.WriteLine(matrix1);
    }
}
