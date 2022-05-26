using System;
using System.Collections.Generic;

///<summary>Provides the multiply of a matrix by scalar</summary>
class MatrixMath
{
    ///<Returns>multiply a matrix by scalar</Returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix.Length == 4)
        {
            double[,] matrix2D = new double[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrix2D[i, j] = matrix[i, j] * scalar;
                }
            }
            return (matrix2D);
        }
        else if (matrix.Length == 9)
        {
            double[,] matrix3D = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix3D[i, j] = matrix[i, j] * scalar;
                }
            }
            return (matrix3D);
        }
        double[,] errorMatrix = new double[1, 1];
        errorMatrix[0, 0] = -1;
        return (errorMatrix);
    }
}
