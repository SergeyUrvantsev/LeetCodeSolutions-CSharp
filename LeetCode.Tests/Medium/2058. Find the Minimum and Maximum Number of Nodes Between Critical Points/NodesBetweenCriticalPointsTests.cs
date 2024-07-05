using LeetCode.Solutions.Common;
using LeetCode.Solutions.Medium._1552._Magnetic_Force_Between_Two_Balls;
using LeetCode.Solutions.Medium._2058._Find_the_Minimum_and_Maximum_Number_of_Nodes_Between_Critical_Points;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Medium._2058._Find_the_Minimum_and_Maximum_Number_of_Nodes_Between_Critical_Points
{
    public class NodesBetweenCriticalPointsTests
    {
        [Theory]
        [InlineData(new int[] { 3, 1 }, new int[] { -1, -1 })]
        [InlineData(new int[] { 5, 3, 1, 2, 5, 1, 2 }, new int[] { 1, 3 })]
        [InlineData(new int[] { 1, 3, 2, 2, 3, 2, 2, 2, 7 }, new int[] { 3, 3 })]
        public void TestNodesBetweenCriticalPoints(int[] head, int[] expected)
        {
            // Arrange
            var solution = new NodesBetweenCriticalPoints();

            // Act
            var result = solution.Solve(ListNode.FromArray(head));

            // Assert
            Assert.Equal(expected[0], result[0]);
            Assert.Equal(expected[1], result[1]);
        }
    }
}
