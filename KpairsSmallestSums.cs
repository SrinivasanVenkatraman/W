using System;
using System.Collections.Generic;
using System.Text;

namespace Walmart
{
    class KpairsSmallestSums
    {
        //Input: nums1 = [1,7,11], nums2 = [2,4,6], k = 3
        //Output: [[1,2],[1,4],[1,6]]
        public IList<IList<int>> KSmallestSumPairs(int[] nums1, int[] nums2, int k)
        {

            var allPairs = new List<List<int>>();
            var result = new List<IList<int>>();

            for (int i = 0; i < Math.Min(nums1.Length, k); ++i)
            {
                for (int j = 0; j < Math.Min(nums2.Length, k); ++j)
                {
                    allPairs.Add(new List<int> { nums1[i], nums2[j] });
                }
            }

            allPairs.Sort((x, y) => (x[0] + x[1]) - (y[0] + y[1]));

            for (int i = 0; i < Math.Min(k, allPairs.Count); ++i)
            {
                result.Add(allPairs[i]);
            }

            return result;
        }
    }
}
