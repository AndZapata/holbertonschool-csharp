using System;

namespace Text
{
    /// <summary>
    /// Class Str.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Function to return the index of the first unique char
        /// </summary>
        /// <param name="s">the string</param>
        /// <returns>The index of the first unique char or -1 if not</returns>
        public static int UniqueChar(string s)
        {
            int len = 256, index = -1, i;
            char[] count = new char[len];

            for (i = 0; i < s.Length; i++)
                count[s[i]]++;

            for (i = 0; i < s.Length; i++)
            {
                if (count[s[i]] == 1)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
