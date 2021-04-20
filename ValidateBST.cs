using System;
using System.Collections.Generic;
using System.Text;

namespace Walmart
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    class ValidateBST
    {
        public bool IsValidBST(TreeNode root)
        {
            return DFS(root);
        }

        private int? prev = null;
        private bool DFS(TreeNode node)
        {
            if (node == null)
                return true;

            if (!DFS(node.left))
                return false;

            if (prev != null && node.val <= prev)
                return false;

            prev = node.val;
            return DFS(node.right);
        }

    }
}
