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
            if (s.Length == 0)
                return 0;
            string[] newS = s.Split(' ');
            return newS.Length;
        }
    }
}
