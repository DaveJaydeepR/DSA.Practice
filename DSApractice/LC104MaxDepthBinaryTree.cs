using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Practice
{
    internal class LC104MaxDepthBinaryTree
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

        public int MaxDepth(TreeNode root)
        {
            int depth = 0;

            if (root == null)
            {
                return depth;
            }

            var leftMaxDepth = MaxDepth(root.left);
            var rightMaxDepth = MaxDepth(root.right);
            depth = Math.Max(leftMaxDepth, rightMaxDepth) + 1;

            return depth;
        }

    }
}
