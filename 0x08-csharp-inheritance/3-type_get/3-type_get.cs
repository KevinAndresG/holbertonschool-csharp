using System;
using System.Collections.Generic;
using System.Reflection;

///<sumary>Object classes</sumary>
class Obj
{
	///<sumary>print all methods and properties of an obj</sumary>
	public static void Print(object myObj)
	{
		PropertyInfo[] myPropertyInfo;
		myPropertyInfo = myObj.GetType().GetProperties();

		MethodInfo[] myMethodInfo;
		myMethodInfo = myObj.GetType().GetMethods();

		Console.WriteLine("{0} Properties:", myObj.GetType());
		for (int i = 0; i < myPropertyInfo.Length; i++)
		{
			Console.WriteLine(myPropertyInfo[i]);
		}

		Console.WriteLine("{0} Methods:", myObj.GetType());
		for (int j = 0; j < myMethodInfo.Length; j++)
		{
			Console.WriteLine(myMethodInfo[j]);
		}
	}
}
