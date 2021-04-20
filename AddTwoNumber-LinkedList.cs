using System;
using System.Collections.Generic;
using System.Text;

namespace Walmart
{
    class AddTwoNumber_LinkedList
    {
        //The digits are stored in reverse order
        // [2,4,3], l2 = [5,6,4] ; result = 708
        //342 + 465 = 807.


         public class ListNode
         {
              public int val;
              public ListNode next;
              public ListNode(int val = 0, ListNode next = null)
              {
                        this.val = val;
                        this.next = next;
              }
         }



        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            var carryOver = 0;
            var head = new ListNode(0);
            ListNode curr = head;
            while (l1 != null || l2 != null)
            {
                int s1 = (l1 != null) ? l1.val : 0;
                int s2 = (l2 != null) ? l2.val : 0;

                int sum = s1 + s2 + carryOver;
                carryOver = sum / 10;

                curr.next = new ListNode(sum % 10);
                curr = curr.next;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }

            if (carryOver > 0)
                curr.next = new ListNode(carryOver);

            // preHead node pattern
            return head.next;

        }
    }
}
