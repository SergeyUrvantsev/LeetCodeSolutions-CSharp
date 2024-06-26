using LeetCode.Solutions.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Medium._1382._Balance_a_Binary_Search_Tree
{
    public class BalanceBST
    {
        //Complexity:
        //Time complexity: O(n), где n это количество узлов в дереве
        //Space complexity: O(1)

        public TreeNode? Solve(TreeNode root)
        {
            var values = new List<int>();
            InOrderTraversal(root);
            return BuildBalancedBST(0, values.Count - 1);

            void InOrderTraversal(TreeNode node)
            {
                if (node == null) return;
                InOrderTraversal(node.left);
                values.Add(node.val);
                InOrderTraversal(node.right);
            }

            TreeNode? BuildBalancedBST(int start, int end)
            {
                if (start > end) return null;
                int mid = (start + end) / 2;
                TreeNode node = new TreeNode(values[mid]);
                node.left = BuildBalancedBST(start, mid - 1);
                node.right = BuildBalancedBST(mid + 1, end);
                return node;
            }
        }
    }
}
