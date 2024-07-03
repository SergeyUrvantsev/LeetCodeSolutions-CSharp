using LeetCode.Solutions.Medium._1482._Minimum_Number_of_Days_to_Make_m_Bouquets;
using LeetCode.Solutions.Medium._1509._Minimum_Difference_Between_Largest_and_Smallest_Value_in_Three_Moves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Medium._1509._Minimum_Difference_Between_Largest_and_Smallest_Value_in_Three_Moves
{
    public class MinDifferenceTests
    {
        [Theory]
        [InlineData(new int[] { 5, 3, 2, 4 }, 0)]
        [InlineData(new int[] { 1, 5, 0, 10, 14 }, 1)]
        [InlineData(new int[] { 3, 100, 20 }, 0)]
        [InlineData(new int[] { 82, 81, 95, 75, 20 }, 1)]
        public void TestMinDifference(int[] nums, int expected)
        {
            // Arrange
            var solution = new MinDifference();

            // Act
            var result = solution.Solve(nums);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
