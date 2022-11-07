using System;

///<summary>Provide a type</summary>
class Queue<T>
{
    ///<Returns>Return the type of any generic</Returns>
    public Type CheckType()
    {
        return (typeof(T));
    }
}
