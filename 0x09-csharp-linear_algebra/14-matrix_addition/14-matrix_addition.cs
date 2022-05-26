using System;
using System.Collections.Generic;

///<summary>Provides the add of two matrixes</summary>
class MatrixMath
{
    ///<Returns>add two matrixes</Returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.Length == 4 && matrix2.Length == 4)
        {
            double[,] matrix2D = new double[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrix2D[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return (matrix2D);
        }
        else if (matrix1.Length == 9 && matrix2.Length == 9)
        {
            double[,] matrix3D = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix3D[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return (matrix3D);
        }
        double[,] errorMatrix = new double[1, 1];
        errorMatrix[0, 0] = -1;
        return (errorMatrix);
    }
}
