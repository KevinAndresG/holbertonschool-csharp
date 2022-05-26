using System;

class Program
{
    static void Main()
    {
        int count = 0;
        double[,] matrix1 = { { 1, 2, 5 }, { 3, 4, 3 }, { 1, 2, 8 } };
        double[,] matrix2 = { { 2, 3, 2 }, { 4, 6, 5 }, { 3, 4, 3 } };
        double[,] matrix = MatrixMath.Add(matrix1, matrix2);
        foreach (var item in matrix)
        {
            if (count == 3)
            {
                Console.WriteLine();
            }
            if (count == 6)
            {
                Console.WriteLine();
            }
            Console.Write($"{item} ");
            count++;
        }
        Console.WriteLine();
    }
}
