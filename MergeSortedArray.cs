using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Walmart
{
    class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            List<int> output = nums1.ToList().GetRange(0, m);
            output.AddRange(nums2.ToList().GetRange(0, n));
            output.Sort();

            for (int i = 0; i < output.Count; i++)
            {
                nums1[i] = output[i];
            }

        }

    }
}
