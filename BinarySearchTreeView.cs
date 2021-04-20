using System;
using System.Collections.Generic;
using System.Text;

namespace Walmart
{
    class BinarySearchTreeView
    {
        public IList<int> RightSideView(TreeNode root)
        {
            var result = new List<int>();
            if (root == null) return result;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode curr = null;
                var count = queue.Count;
                for (var i = 0; i < count; i++)
                {
                    curr = queue.Dequeue();
                    if (curr.left != null) queue.Enqueue(curr.left);
                    if (curr.right != null) queue.Enqueue(curr.right);
                    // swapping this left to right will give left side view
                }
                result.Add(curr.val);
            }

            return result;
        }
    }
}
