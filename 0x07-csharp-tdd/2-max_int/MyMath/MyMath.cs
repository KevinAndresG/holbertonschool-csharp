using System;
using System.Collections.Generic;

namespace MyMath
{
	///<sumary>Make operations</sumary>
	public class Operations
	{
		///<Returns>Return the max integer</Returns>
		public static int Max(List<int> nums)
		{
			if (nums.Count == 0)
			{
				return (0);
			}
			nums.Sort();
			Console.WriteLine(nums[nums.Count - 1].GetType());
			return (nums[nums.Count - 1]);
		}
	}
}
