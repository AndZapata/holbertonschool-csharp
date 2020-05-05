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
        public void emptyCase()
        {
            string s = "";
            int result = Str.CamelCase(s);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void defaultCase()
        {
            string s = "some Words To Read";
            int result = Str.CamelCase(s);
            Assert.AreEqual(4, result);
        }
        [Test]
        public void oneWordCase()
        {
            string s = "some";
            int result = Str.CamelCase(s);
            Assert.AreEqual(1, result);
        }
        [Test]
        public void oneCharCase()
        {
            string s = "s";
            int result = Str.CamelCase(s);
            Assert.AreEqual(1, result);
        }
    }
}