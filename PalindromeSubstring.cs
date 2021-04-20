using System;
using System.Collections.Generic;
using System.Text;

namespace Walmart
{
    class PalindromeSubstring
    {
        public string LongestPalindrome(string s)
        {

            if (s == null || s.Length == 0)
                return "";

            int length = 0, start = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int oddLength = ExpandFromCenter(s, i, i);
                int evenLength = ExpandFromCenter(s, i, i + 1);
                int currLength = Math.Max(oddLength, evenLength);

                if (currLength > length)
                {
                    length = currLength;
                    start = i - (length - 1) / 2;
                }
            }

            return s.Substring(start, length);
        }

        private int ExpandFromCenter(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }

            return right - left - 1;//(right - 1) - (left + 1) + 1;
        }
    }
}
