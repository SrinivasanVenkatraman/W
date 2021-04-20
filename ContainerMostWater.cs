using System;
using System.Collections.Generic;
using System.Text;

namespace Walmart
{
    class ContainerMostWater
    {
        public int MaxArea(int[] height)
        {
            var i = 0;
            var j = height.Length - 1;
            var max = int.MinValue;
            while (i < j)
            {
                var width = j - i;
                var heigth = Math.Min(height[i], height[j]);
                max = Math.Max(max, width * heigth);

                if (height[i] < height[j])
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }
            return max;
        }
    }
}
