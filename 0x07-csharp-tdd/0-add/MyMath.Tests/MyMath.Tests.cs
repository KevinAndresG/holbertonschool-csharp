using NUnit.Framework;

namespace MyMath.Tests
{
	[TestFixture]
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void test1()
		{
			Assert.AreEqual(28, Operations.Add(14, 14));
		}
		[Test]
		public void test2()
		{
			Assert.AreEqual(9, Operations.Add(5, 4));
		}
		[Test]
		public void cero()
		{
			Assert.AreEqual(0, Operations.Add(-5, 5));
		}
		[Test]
		public void negpos()
		{
			Assert.AreEqual(10, Operations.Add(-15, 25));
		}
		[Test]
		public void sameType()
		{
			Assert.AreEqual(8.GetType(), Operations.Add(4, 4).GetType());
		}
		[Test]
		public void sameType2()
		{
			Assert.AreNotEqual("8".GetType(), Operations.Add(4, 4).GetType());
		}
		[Test]
		public void sameType3()
		{
			Assert.AreNotEqual("Hello World".GetType(), Operations.Add(4, 4).GetType());
		}
		[Test]
		public void sameType4()
		{
			Assert.AreNotEqual(true.GetType(), Operations.Add(4, 4).GetType());
		}
	}
}
