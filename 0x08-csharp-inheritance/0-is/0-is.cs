using System;
using System.Collections.Generic;

///<sumary>Object classes</sumary>
public class Obj
{
	///<Returns>Return true if is int else return false</Returns>
	public static bool IsOfTypeInt(object obj)
	{
		if (obj.GetType() == typeof(int))
		{
			return (true);
		}
		else
		{
			return (false);
		}
	}
}
