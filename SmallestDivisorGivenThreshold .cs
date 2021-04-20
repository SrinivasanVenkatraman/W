using System;
using System.Collections.Generic;
using System.Text;

namespace Walmart
{
    class SmallestDivisorGivenThreshold
    {


        public int ThresoldDivisor(int[] nums, int threshold)
        {
            int low = 1;
            int high = 1000000;
            int mid = (low + high) / 2;

            while (low < high)
            {
                int sum = 0;
                mid = (low + high) / 2;
                for (int i = 0; i < nums.Length; i++)
                {
                    sum = sum + (nums[i] + mid - 1) / mid;
                }
                if (sum > threshold)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }
            return low;

        }





        public int SmallestDivisor(int[] nums, int threshold)
        {
            int start = 1;
            int end = int.MaxValue;
            while (start < end)
            {
                int mid = start + (end - start) / 2;
                if (IsValid(nums, threshold, mid))
                    end = mid;
                else
                    start = mid + 1;
            }

            return start;
        }

        private bool IsValid(int[] nums, int threshold, int divisor)
        {
            int sum = 0;
            foreach (var num in nums)
            {
                sum += (int)Math.Ceiling((double)num / (double)divisor);
            }

            return sum <= threshold;
        }
    }
}
