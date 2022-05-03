using System;
using System.Collections.Generic;

///<sumary>Object classes</sumary>
public class Obj
{
	///<Returns>Return true if is an instace of </Returns>
	public static bool IsInstanceOfArray(object obj)
	{
		if (typeof(Array).IsInstanceOfType(obj))
		{
			return (true);
		}
		else
		{
			return (false);
		}
	}
}
