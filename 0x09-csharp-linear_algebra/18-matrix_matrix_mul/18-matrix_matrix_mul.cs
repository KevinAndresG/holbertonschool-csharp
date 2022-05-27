using System;
using System.Collections.Generic;

///<summary>Provides the multiply of a matrix by another</summary>
class MatrixMath
{
    ///<Returns>multiply a matrix by another</Returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int m = matrix1.GetLength(1), q = matrix2.GetLength(1), n = matrix1.GetLength(0);
        if (m != q)
        {
            double[,] errorMatrix = new double[1, 1];
            errorMatrix[0, 0] = -1;
            return (errorMatrix);
        }
        double[,] matrix2D = new double[m, q];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < q; j++)
            {
                matrix2D[i, j] = 0;
                for (int k = 0; k < n; k++)
                {
                    matrix2D[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return (matrix2D);
    }
}