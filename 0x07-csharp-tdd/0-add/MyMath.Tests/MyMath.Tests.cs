using NUnit.Framework;

namespace MyMath.Tests
{
    /// <summary> Test cases. </summary>
    [TestFixture]
    public class Operations_Tests
    {
        [Test]
        public void ArrangeTest()
        {
            Assert.Pass();
        }

        [Test]
        public void AddPositivesInt()
        {
            int a = 2, b = 3;
            int result = Operations.Add(a, b);
            Assert.Positive(result);
            Assert.AreEqual(5, result);
        }
        [Test]
        public void AddNegativesInt()
        {
            int a = -5, b = -9;
            int result = Operations.Add(a, b);
            Assert.Negative(result);
            Assert.AreEqual(-14, result);
        }
        [Test]
        public void AddNegativesPositivesInt()
        {
            int a = 8, b = -600;
            int result = Operations.Add(a, b);
            Assert.Negative(result);
            Assert.AreEqual(-592, result);
        }
        [Test]
        public void AddZeroToInt()
        {
            int a = 0, b = 10;
            int result = Operations.Add(a, b);
            Assert.Positive(result);
            Assert.AreEqual(10, result);
        }
        [Test]
        public void AddZeroToZero()
        {
            int a = 0, b = 0;
            int result = Operations.Add(a, b);
            Assert.Zero(result);
        }
    }
}
