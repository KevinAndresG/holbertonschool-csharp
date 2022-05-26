using System;
using System.Collections.Generic;

///<summary>Provides the multiplying of two Vectors</summary>
class VectorMath
{
    ///<Returns>two vectors multiplyied</Returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] errorVector = new double[1];
        if (vector.Length == 2)
        {
            //Logic for 2D Vectors
            double[] twoDVector = new double[2];
            for (int i = 0; i < 2; i++)
            {
                twoDVector[i] = vector[i] * scalar;
            }
            return (twoDVector);
        }
        if (vector.Length == 3)
        {
            //Logic for 3D Vectors
            double[] threeDVector = new double[3];
            for (int i = 0; i < 3; i++)
            {
                threeDVector[i] = vector[i] * scalar;
            }
            return (threeDVector);
        }
        else
            errorVector[0] = -1;
        return (errorVector);
    }
}
