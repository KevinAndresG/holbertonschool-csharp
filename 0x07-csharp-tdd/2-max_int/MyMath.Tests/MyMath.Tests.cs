using NUnit.Framework;
using MyMath;
using System.Collections.Generic;

namespace MyMath.Tests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Test1()
		{
			List<int> myList = new List<int>() { 1, 2, 3, 5, 6, 8, 10 };
			Assert.AreEqual(10, Operations.Max(myList));
		}
		[Test]
		public void Test2()
		{
			List<int> myList = new List<int>();
			Assert.AreEqual(0, Operations.Max(myList));
		}
		[Test]
		public void sameType()
		{
			List<int> myList = new List<int>() { 1, 2, 3, 5, 6, 8, 10 };
			Assert.AreEqual(10.GetType(), Operations.Max(myList).GetType());
		}
		[Test]
		public void sameType2()
		{
			List<int> myList = new List<int>() { 1, 2, 3, 5, 6, 8, 10 };
			Assert.AreNotEqual("8".GetType(), Operations.Max(myList).GetType());
		}
		[Test]
		public void sameType3()
		{
			List<int> myList = new List<int>() { 1, 2, 3, 5, 6, 8, 10 };
			Assert.AreNotEqual("Hello World".GetType(), Operations.Max(myList).GetType());
		}
	}
}
