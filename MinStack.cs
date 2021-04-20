using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Walmart
{
    class MinStack
    {
        private List<int> Data { get; set; }

        /** initialize your data structure here. */
        public MinStack()
        {
            Data = new List<int>();
        }

        public void Push(int val)
        {
            Data.Add(val);
        }

        public void Pop()
        {
            Data.RemoveAt(Data.Count - 1);
        }

        public int Top()
        {
            return Data.ElementAt(Data.Count - 1);
        }

        public int GetMin()
        {
            return Data.Min();
        }
    }
}
