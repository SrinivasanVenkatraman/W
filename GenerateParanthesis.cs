using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Walmart
{
    class GenerateParanthesis
    {
        public IList<string> GenerateParenthesis1(int n)
        {
            IList<string> answer = new List<string>();
            if (n == 0)
            {
                answer.Add("");
                return answer;
            }
            if (n == 1)
            {
                answer.Add("()");
                return answer;
            }
            HashSet<string> hashset = new HashSet<string>();
            // Recursive approach 
            foreach (string str in GenerateParenthesis1(n - 1))
            {

                // Add () pattern between 0 and n location 
                for (int i = 0; i < str.Length; i++)
                {
                    string newstr = str.Insert(i, "()");
                    hashset.Add(newstr);
                }
            }
            return hashset.ToList();
        }
    }
}
