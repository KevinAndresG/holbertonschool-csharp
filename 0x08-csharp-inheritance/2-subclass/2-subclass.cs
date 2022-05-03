using System;
using System.Collections.Generic;

///<sumary>Object classes</sumary>
public class Obj
{
	///<Returns>Return true if is an instace of specific class</Returns>
	public static bool IsOnlyASubclass(Type derivedType, Type baseType)
	{
		if (derivedType.IsSubclassOf(baseType))
		{
			return (true);
		}
		else
		{
			return (false);
		}
	}
}
