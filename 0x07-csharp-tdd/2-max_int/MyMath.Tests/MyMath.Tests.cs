using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void arrangeTest()
        {
            Assert.Pass();
        }
        [Test]
        public void emptyList()
        {
            List<int> nums = null;
            int result = Operations.Max(nums);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void maxIntegerList()
        {
            List<int> nums = new List<int> {4, 3, 5, 7, 1, 2};
            int result = Operations.Max(nums);
            Assert.AreEqual(7, result);
        }
        [Test]
        public void negativeIntegersList()
        {
            List<int> nums = new List<int> {-4, -3, -5, -7, -1, -2};
            int result = Operations.Max(nums);
            Assert.AreEqual(-1, result);
        }
        [Test]
        public void negativePositiveIntegersList()
        {
            List<int> nums = new List<int> {-4, -3, -5, 7, 1, -2};
            int result = Operations.Max(nums);
            Assert.AreEqual(7, result);
        }
        [Test]
        public void zeroMaxIntegersList()
        {
            List<int> nums = new List<int> {-4, -3, -5, -7, 0, -2};
            int result = Operations.Max(nums);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void MaxIntSortList()
        {
            List<int> nums = new List<int> {-8, -4, -2, 0, 1, 3, 80, 99, 1024, 2048, 4056};
            int result = Operations.Max(nums);
            Assert.AreEqual(4056, result);
        }
    }
}
