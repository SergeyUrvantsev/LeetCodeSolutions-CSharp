using LeetCode.Solutions.Common;
using LeetCode.Solutions.Medium._1382._Balance_a_Binary_Search_Tree;
using LeetCode.Solutions.Medium._2181._Merge_Nodes_in_Between_Zeros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Medium._2181._Merge_Nodes_in_Between_Zeros
{
    public class MergeNodesTests
    {
        [Fact]
        public void TestExample1()
        {
            var head = ListNode.FromArray(new int[] { 0, 3, 1, 0, 4, 5, 2, 0 });
            var expected = ListNode.FromArray(new int[] { 4, 11 });

            var solution = new MergeNodes();
            var result = solution.Solve(head);

            Assert.True(AreListEqual(expected, result));
        }

        [Fact]
        public void TestExample2()
        {
            var head = ListNode.FromArray(new int[] { 0, 1, 0, 3, 0, 2, 2, 0 });
            var expected = ListNode.FromArray(new int[] { 1, 3, 4 });

            var solution = new MergeNodes();
            var result = solution.Solve(head);

            Assert.True(AreListEqual(expected, result));
        }

        private bool AreListEqual(ListNode t1, ListNode t2)
        {
            if (t1 == null && t2 == null) return true;
            if (t1 == null || t2 == null) return false;
            if (t1.val != t2.val) return false;
            return AreListEqual(t1.next, t2.next);
        }
    }
}
