using System;
using System.Collections.Generic;
using System.Text;

namespace Walmart
{
    class TrapWater
    {

        // 2pointer approach
        public int Trap(int[] height)
        {
            if (height == null || height.Length == 0)
                return 0;

            int left = 0, right = height.Length - 1;
            int leftMax = height[left], rightMax = height[right], ans = 0;

            while (left < right)
            {
                if (leftMax < rightMax)
                {
                    ans += Math.Max(0, leftMax - height[left]);
                    left++;
                    leftMax = Math.Max(leftMax, height[left]);
                }
                else
                {
                    ans += Math.Max(0, rightMax - height[right]);
                    right--;
                    rightMax = Math.Max(rightMax, height[right]);
                }
            }
            return ans;
        }
    }
}
