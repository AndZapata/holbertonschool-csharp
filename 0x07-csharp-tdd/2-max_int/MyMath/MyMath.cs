using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Class operations
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Function that search in a List the max integer
        /// </summary>
        /// <param name="nums">List of integers</param>
        /// <returns>the max integer</returns>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
                return 0;
            nums.Sort();
            return nums[nums.Count - 1];
        }
    }
}
