using System;
using System.Collections.Generic;

///<summary>Provides the multiplying of two Vectors</summary>
class VectorMath
{
    ///<Returns>Dot Product of two vectors</Returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double result = 0;
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            // Logic for 2D Vector
            for (int i = 0; i < 2; i++)
            {
                result += vector1[i] * vector2[i];
            }
            return (result);
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            // Logic for 3D Vector
            for (int i = 0; i < 3; i++)
            {
                result += vector1[i] * vector2[i];
            }
            return (result);
        }
        return (-1);
    }
    static void Main()
    {
        double[] vector1 = { 3, 5, 6 };
        double[] vector2 = { 2, 4, 2 };
        Console.WriteLine(DotProduct(vector1, vector2));
    }
}
