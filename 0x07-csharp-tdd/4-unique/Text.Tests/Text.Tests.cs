using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void arrangeTest()
        {
            Assert.Pass();
        }
        [Test]
        public void emptyString()
        {
            string s = "";
            int result = Str.UniqueChar(s);
            Assert.AreEqual(-1, result);
        }
        [Test]
        public void oneCharString()
        {
            string s = "a";
            int result = Str.UniqueChar(s);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void lastCharString()
        {
            string s = "aabbccd";
            int result = Str.UniqueChar(s);
            Assert.AreEqual(6, result);
        }
        [Test]
        public void middleCharString()
        {
            string s = "aabbcddee";
            int result = Str.UniqueChar(s);
            Assert.AreEqual(4, result);
        }
        [Test]
        public void allRepeatCharString()
        {
            string s = "aabbccdd";
            int result = Str.UniqueChar(s);
            Assert.AreEqual(-1, result);
        }
        [Test]
        public void firstCharString()
        {
            string s = "abbccdd";
            int result = Str.UniqueChar(s);
            Assert.AreEqual(0, result);
        }
        
    }
}