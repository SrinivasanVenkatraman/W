using System;
using System.Collections.Generic;
using System.Text;

namespace Walmart
{
    class MoveZeros
    {
        //1 2 3 4 0 0 6 7 

        public int[] MoveZero(int[] nums)
        {
            if(nums.Length == 0)
            {
                return nums;
            }

            int zeroCounter = 0;

            for(int i=0; i< nums.Length; i++)
            {
               if(nums[i] == 0)
                {
                    zeroCounter++;
                    continue;
                }
               else
                {
                    if(zeroCounter >= 1)
                    {
                        nums[i - zeroCounter] = nums[i];
                        nums[i] = 0;
                    }
                }
            }


            return nums;
        }

    }
}
