using System;
using System.Collections.Generic;

///<summary>Provides the add of two Vectors</summary>
class VectorMath
{
    ///<Returns>the add of two vectors</Returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] addedVector;
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            // Logic for 2D Vector
            double[] newVector2D = new double[2];
            for (int i = 0; i < 2; i++)
            {
                newVector2D[i] = vector1[i] + vector2[i];
            }
            return (newVector2D);
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            // Logic for 3D Vector
            double[] newVector3D = new double[3];
            for (int i = 0; i < 3; i++)
            {
                newVector3D[i] = vector1[i] + vector2[i];
            }
            return (newVector3D);
        }
        addedVector = new double[1];
        addedVector[0] = -1;
        return (addedVector);
    }
}
