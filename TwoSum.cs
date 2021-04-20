using System;
using System.Collections.Generic;
using System.Text;

namespace Walmart
{
    class TwoSum
    {

        // 0 1 2 4 5 6 --> 10
        //   9 8 6 5 already present 6
        //   

        public static int[] TwoSumIndexReturn(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2)
                return new int[2];

            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    return new int[] { dict[target - nums[i]], i };
                }
                else if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }


            }
            return new int[2];
        }
    }
}
