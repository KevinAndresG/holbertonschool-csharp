using System;
using System.Collections.Generic;
using System.Collections;
///<summary>Provides the size of a Vector</summary>
class VectorMtah
{
    ///<Returns>the size of the vector 2D or 3D</Returns>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length == 2)
        {
            // Logic for 2D Vector
            return Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2)));
        }
        if (vector.Length == 3)
        {
            // Logic for 3D Vector
            return Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2)));
        }
        return (-1);
    }
}
