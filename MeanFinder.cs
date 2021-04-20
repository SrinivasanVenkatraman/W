using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Walmart
{
    public class MeanFinder
    {
        List<int> Numbers;
        /** initialize your data structure here. */
        public MeanFinder()
        {
            Numbers = new List<int>();
        }

        public void AddNum(int num)
        {
            int position = Numbers.BinarySearch(num);

            if (position < 0)
            {
                position = ~position;
            }
            Numbers.Insert(position, num);
        }

        public double FindMedian()
        {

            return (double)Numbers.Average();
           


        }
    }

}
