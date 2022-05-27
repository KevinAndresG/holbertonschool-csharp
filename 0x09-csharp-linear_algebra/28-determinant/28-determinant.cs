using System;
using System.Collections.Generic;

///<summary>Provides the determinant of a matrix</summary>
class MatrixMath
{
    ///<Returns>determinant of a matrix</Returns>
    public static double Determinant(double[,] matrix)
    {
        double det = 0;
        if (matrix.GetLength(1) == 2)
        {
            det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            return (det);
        }
        else if (matrix.GetLength(1) == 3)
        {
            det = matrix[0, 0] * ((matrix[1, 1] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 1])) -
                    matrix[0, 1] * ((matrix[1, 0] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 0])) +
                    matrix[0, 2] * ((matrix[1, 0] * matrix[2, 1]) - (matrix[1, 1] * matrix[2, 0]));
            return (det);
        }
        return (-1);
    }
}
