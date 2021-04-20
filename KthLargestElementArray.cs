using System;
using System.Collections.Generic;
using System.Text;

namespace Walmart
{
    class KthLargestElementArray
    {

        //Input: nums = [3,2,3,1,2,4,5,5,6], k = 4
        //Output: 4


        public int FindKthLargest(int[] nums, int k)
        {
            //   return nums.OrderByDescending(n => n).ElementAt(k - 1);

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], 0);
                }
                else
                {
                    dict[nums[i]]++;
                }

            }

            var list = dict.Keys.ToList();
            list.Sort();

            var result = 0;

            for (var i = list.Count - 1; i >= 0; i--)
            {
                result = result + dict[list[i]];
                if (result >= k)
                    return list[i];
            }
            return 0;

        }
    }
}
