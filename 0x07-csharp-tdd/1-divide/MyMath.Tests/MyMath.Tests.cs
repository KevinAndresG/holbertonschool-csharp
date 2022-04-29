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
		public void Test1()
		{
			int[,] mat = new int[,] { { 4, 5 }, { 3, 1 } };
			int[,] res = new int[,] { { 2, 2 }, { 1, 0 } };

			Assert.AreEqual(res, Matrix.Divide(mat, 2));
		}
		[Test]
		public void Test2()
		{
			int[,] mat = new int[,] { { 4, 6 }, { 3, 1 } };

			Assert.AreEqual(null, Matrix.Divide(mat, 0));
		}
		[Test]
		public void Test3()
		{
			Assert.AreEqual(null, Matrix.Divide(null, 2));
		}
	}
}
