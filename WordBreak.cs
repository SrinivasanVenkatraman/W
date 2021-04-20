using System;
using System.Collections.Generic;
using System.Text;

namespace Walmart
{
    class WordBreak
    {
        public bool WordBreaker(string s, IList<string> wordDict)
        {
            if (string.IsNullOrEmpty(s))
                return true;
            for (int i = 0; i < wordDict.Count; i++)
            {
                if (s.StartsWith(wordDict[i]) && WordBreaker(s.Substring(wordDict[i].Length), wordDict))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
