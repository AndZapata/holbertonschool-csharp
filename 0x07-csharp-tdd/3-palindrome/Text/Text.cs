using System;
using System.Text.RegularExpressions;

namespace Text
{
    /// <summary>
    /// Class Str
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Function to check is a string is a palindrome
        /// </summary>
        /// <param name="s">The inpur string to be checked</param>
        /// <returns>True if is a palindrome, false if not</returns>
        public static bool IsPalindrome(string s)
        {
            if (s.Length < 2)
                return true;
            s = s.ToLower();
            s = Regex.Replace(s, "[:;,. \t\n\r]", "");
            int len = s.Length;
            int i = 0;
            while (i < s.Length)
            {
                if (s[i] != s[len - 1])
                    return false;
                i++;
                len--;
            }
            return true;
        }
    }
}
