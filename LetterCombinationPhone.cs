using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Walmart
{
    class LetterCombinationPhone
    {
        public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrWhiteSpace(digits))
                return new List<string>();

            var letters = new[] { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            var queue = new Queue<string>();
            queue.Enqueue("");
            foreach (var i in digits)
            {
                var count = queue.Count;
                while (count > 0)
                {
                    var comb = queue.Dequeue();
                    foreach (var c in letters[i - '2'])
                    {
                        queue.Enqueue(comb + c);
                    }

                    count--;
                }
            }
            return queue.ToList();
        }

    }
}
