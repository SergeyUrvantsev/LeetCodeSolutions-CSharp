using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LeetCode.Solutions.Common;

namespace LeetCode.Solutions.Medium._1038._Binary_Search_Tree_to_Greater_Sum_Tree
{
    public class BstToGst
    {
        //Complexity:
        //Time complexity: O(n), где n это количество узлов в дереве
        //Space complexity: O(1)

        private int _sum = 0;

        public TreeNode? Solve(TreeNode node)
        {
            if (node == null) return null;
            Solve(node.right);
            node.val = _sum += node.val;
            Solve(node.left);
            return node;
        }
    }
}
