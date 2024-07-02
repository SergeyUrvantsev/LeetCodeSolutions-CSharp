using LeetCode.Solutions.Easy._1550._Three_Consecutive_Odds;
using LeetCode.Solutions.Easy._350._Intersection_of_Two_Arrays_II;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Easy._350._Intersection_of_Two_Arrays_II
{
    public class IntersectTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 }, new int[] { 2, 2 })]
        [InlineData(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }, new int[] { 4, 9 })]
        public void TestIntersect(int[] nums1, int[] nums2, int[] expected)
        {
            // Arrange
            var solution = new Intersect();

            // Act
            var result = solution.Solve(nums1, nums2);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
