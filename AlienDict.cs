using System;
using System.Collections.Generic;
using System.Text;

namespace Walmart
{
    class AlienDict
    {
        public bool IsAlienSorted(string[] words, string order)
        {
            int[] index = new int[26];
            for (int i = 0; i < order.Length; i++)
                index[order[i] - 'a'] = i;

            for (int i = 0; i < words.Length - 1; i++)
            {
                string word1 = words[i];
                string word2 = words[i + 1];

                for (int j = 0; j < word1.Length; j++)
                {
                    if (j < word2.Length && word1[j] == word2[j])
                        continue;
                    else if (j < word2.Length && index[word1[j] - 'a'] < index[word2[j] - 'a'])
                        break;

                    return false;
                }
            }

            return true;
        }
    }
}
