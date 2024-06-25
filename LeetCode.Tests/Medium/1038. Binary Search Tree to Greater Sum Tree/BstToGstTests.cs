using LeetCode.Solutions.Medium._1038._Binary_Search_Tree_to_Greater_Sum_Tree;
using LeetCode.Solutions.Medium._1482._Minimum_Number_of_Days_to_Make_m_Bouquets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Medium._1038._Binary_Search_Tree_to_Greater_Sum_Tree
{
    public class BstToGstTests
    {
        [Fact]
        public void TestExample1()
        {
            var root = new TreeNode(4,
                new TreeNode(1,
                    new TreeNode(0),
                    new TreeNode(2, null, new TreeNode(3))
                ),
                new TreeNode(6,
                    new TreeNode(5),
                    new TreeNode(7, null, new TreeNode(8))
                )
            );

            var expected = new TreeNode(30,
                new TreeNode(36,
                    new TreeNode(36),
                    new TreeNode(35, null, new TreeNode(33))
                ),
                new TreeNode(21,
                    new TreeNode(26),
                    new TreeNode(15, null, new TreeNode(8))
                )
            );

            var solution = new BstToGst();
            var result = solution.Solve(root);

            Assert.True(AreTreesEqual(expected, result));
        }

        [Fact]
        public void TestExample2()
        {
            var root = new TreeNode(0, null, new TreeNode(1));
            var expected = new TreeNode(1, null, new TreeNode(1));

            var solution = new BstToGst();
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
