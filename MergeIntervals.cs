using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Walmart
{
    class MergeIntervals
    {
        //Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
        //Output: [[1,6],[8,10],[15,18]]
        public int[][] MergeInterval(int[][] intervals)
        {
            if (intervals == null || intervals.Length <= 1)
                return intervals;

            List<int[]> res = new List<int[]>();
            var sortedIntervals = intervals.OrderBy(x => x[0]).ToArray();
            res.Add(sortedIntervals[0]);

            for (int i = 1; i < sortedIntervals.Length; i++)
            {
                var curr = sortedIntervals[i];
                var last = res[res.Count - 1];

                if (last[1] >= curr[0])
                    last[1] = Math.Max(last[1], curr[1]);
                else
                    res.Add(curr);
            }

            return res.ToArray();
        }
    }
}
