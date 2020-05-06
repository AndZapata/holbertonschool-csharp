using System;

namespace Text
{
    /// <summary>
    /// Class Str
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Function that returns the count of the words in a string
        /// </summary>
        /// <param name="s">The string</param>
        /// <returns>The count of the words</returns>
        public static int CamelCase(string s)
        {
            if (String.IsNullOrEmpty(s))
                return 0;
            int count = 1;
            for (int i = 0; i < s.Length; i++)
                if (s[i] >= 'A' && s[i] <= 'Z')
                    count += 1;
            return count;
        }
    }
}
