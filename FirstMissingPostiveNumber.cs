using System;
using System.Collections.Generic;
using System.Text;

namespace Walmart
{
    class FirstMissingPostiveNumber
    {
        public int FirstMissingPositive(int[] nums)
        {
            HashSet<int> hash = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!hash.Contains(nums[i]))
                {
                    hash.Add(nums[i]);
                }
            }
            int minVal = 1;
            for (minVal = 1; minVal <= nums.Length; minVal++)
            {
                if (!hash.Contains(minVal))
                    return minVal;
            }
            return minVal;
        }
    }
}
