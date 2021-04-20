using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Walmart
{
    class TopKFrequentElements
    {

        public int[] TopKFrequent(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0 || k == 0)
                return new int[] { };

            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (var item in nums)
            {
                if (!dict.ContainsKey(item))
                    dict.Add(item, 0);

                dict[item] += 1;
            }
            return dict.OrderByDescending(o => o.Value).Take(k).Select(c => c.Key).ToArray();
        }

    }
}
