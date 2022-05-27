using System;
using System.Collections.Generic;

///<summary>Provides the size of a Vector</summary>
class VectorMath
{
    ///<Returns>the size of the vector 2D or 3D</Returns>
    public static double Magnitude(double[] vector)
    {
        double newVector;
        if (vector.Length == 2)
        {
            // Logic for 2D Vector
            newVector = Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2)), 2);
            return newVector;
        }
        else if (vector.Length == 3)
        {
            // Logic for 3D Vector
            newVector = Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2)), 2);
            return newVector;
        }
        return (-1);
    }
}
