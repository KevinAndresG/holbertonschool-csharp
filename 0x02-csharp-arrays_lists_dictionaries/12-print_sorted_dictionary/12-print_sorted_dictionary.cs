﻿using System;
using System.Collections.Generic;

class Dictionary
{
	public static void PrintSorted(Dictionary<string, string> myDict)
	{
		foreach (KeyValuePair<string, string> newDict in myDict.OrderBy(i => i.Key))
		{
			Console.WriteLine("{0}: {1}", newDict.Key, newDict.Value);
		}
	}
}