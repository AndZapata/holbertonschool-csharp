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
            string newStr = "";
            bool result = Str.IsPalindrome(newStr);
            Assert.AreEqual(true, result);
        }
        [Test]
        public void defaultCaseString()
        {
            string newStr = "level";
            bool result = Str.IsPalindrome(newStr);
            Assert.AreEqual(true, result);
        }
        [Test]
        public void isPalindromeNotCaseSensitiveString()
        {
            string newStr = "Racecar";
            bool result = Str.IsPalindrome(newStr);
            Assert.AreEqual(true, result);
        }
        [Test]
        public void isNotPalindromeString()
        {
            string newStr = "ducks";
            bool result = Str.IsPalindrome(newStr);
            Assert.AreEqual(false, result);
        }
        [Test]
        public void isPalindromeLongString()
        {
            string newStr = "A man, a plan, a canal: Panama";
            bool result = Str.IsPalindrome(newStr);
            Assert.AreEqual(true, result);
        }
        [Test]
        public void isNotPalindromeLongString()
        {
            string newStr = "man, a plan, a canal: Panama";
            bool result = Str.IsPalindrome(newStr);
            Assert.AreEqual(false, result);
        }
        [Test]
        public void isPalindromeOneChar()
        {
            string newStr = "a";
            bool result = Str.IsPalindrome(newStr);
            Assert.AreEqual(true, result);
        }
    }
}
