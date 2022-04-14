using System;
using System.Collections.Generic;

class Dictionary
{
	public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
	{
		Dictionary<string, int> dict = new Dictionary<string, int>();
		foreach (KeyValuePair<string, int> newDict in myDict)
		{
			dict[newDict.Key] = newDict.Value * 2;
		}
		return (dict);
	}
}
