using System;
using System.Collections.Generic;
using System.Text;

namespace Walmart
{
    class PermutationII
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            var n = nums.Length;

            var result = new List<IList<int>>();

            if (n == 0)
                return result;

            Array.Sort(nums);
            bool[] isVisited = new bool[n];
            List<int> permutation = new List<int>();
            DFS(nums, isVisited, 0, permutation, result);
            return result;
        }

        private void DFS(int[] nums, bool[] isVisited, int start, IList<int> permutation, IList<IList<int>> result)
        {
            var n = nums.Length;

            if (permutation.Count == n)
            {
                result.Add(new List<int>(permutation));
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (isVisited[i]) 
                        continue;
                    if (i > 0 && nums[i - 1] == nums[i] && isVisited[i - 1]) 
                        continue;

                    permutation.Add(nums[i]);
                    isVisited[i] = true;
                    DFS(nums, isVisited, i, permutation, result);
                    isVisited[i] = false;
                    permutation.RemoveAt(permutation.Count - 1);
                }
            }
        }
    }
}
