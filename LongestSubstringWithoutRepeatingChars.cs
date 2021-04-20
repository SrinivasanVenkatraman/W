using System;
using System.Collections.Generic;
using System.Text;

namespace Walmart
{
    class LongestSubstringWithoutRepeatingChars
    {

        public static int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 1)
                return 1;

            int maxLength = 0;
            List<char> list = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (list.Contains(s[i]))
                {
                    // Remove till the duplicate letter               
                    list.RemoveRange(0, list.IndexOf(s[i]) + 1);

                    // Add the item back
                    list.Add(s[i]);
                }
                else
                {
                    list.Add(s[i]);
                    if (list.Count > maxLength)
                    {
                        maxLength = list.Count;
                    }

                }
            }
            return maxLength;


        }
    }
}
