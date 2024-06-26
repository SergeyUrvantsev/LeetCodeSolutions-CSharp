using LeetCode.Solutions.Common;
using LeetCode.Solutions.Medium._1038._Binary_Search_Tree_to_Greater_Sum_Tree;
using LeetCode.Solutions.Medium._1382._Balance_a_Binary_Search_Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Medium._1382._Balance_a_Binary_Search_Tree
{
    public class BalanceBSTTests
    {
        [Fact]
        public void TestExample1()
        {
            var root = new TreeNode(1, null,
                new TreeNode(2, null,
                    new TreeNode (3, null,
                        new TreeNode(4)
                    )
                )
            );

            var expected = new TreeNode(2,
                new TreeNode(1),
                new TreeNode(3, null, new TreeNode(4))
            );

            var solution = new BalanceBST();
            var result = solution.Solve(root);

            Assert.True(AreTreesEqual(expected, result));
        }

        [Fact]
        public void TestExample2()
        {
            var root = new TreeNode(2, new TreeNode(1), new TreeNode(3));
            var expected = new TreeNode(2, new TreeNode(1), new TreeNode(3));

            var solution = new BalanceBST();
            var result = solution.Solve(root);

            Assert.True(AreTreesEqual(expected, result));
        }

        private bool AreTreesEqual(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null) return true;
            if (t1 == null || t2 == null) return false;
            if (t1.val != t2.val) return false;
            return AreTreesEqual(t1.left, t2.left) && AreTreesEqual(t1.right, t2.right);
        }
    }
}
