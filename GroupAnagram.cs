using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Walmart
{
    class GroupAnagram
    {
        // Input: strs = ["eat","tea","tan","ate","nat","bat"]
        // Output: [["bat"],["nat","tan"],["ate","eat","tea"]]

        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();
            foreach (var s in strs)
            {
                char[] charArray = s.ToCharArray();
                Array.Sort(charArray);
                var key = new string(charArray);

                if (!dict.ContainsKey(key))
                {
                    dict[key] = new List<string>();
                }
                dict[key].Add(s);
            }
            return dict.Values.ToList();
        }
    }
}
