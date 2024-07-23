using LeetCode.Solutions.Easy._1550._Three_Consecutive_Odds;
using LeetCode.Solutions.Easy._1636._Sort_Array_by_Increasing_Frequency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Easy._1636._Sort_Array_by_Increasing_Frequency
{
    public class FrequencySortTests
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 2, 2, 2, 3 }, new int[] { 3, 1, 1, 2, 2, 2 })]
        [InlineData(new int[] { 2, 3, 1, 3, 2 }, new int[] { 1, 3, 3, 2, 2 })]
        [InlineData(new int[] { -1, 1, -6, 4, 5, -6, 1, 4, 1 }, new int[] { 5, -1, 4, 4, -6, -6, 1, 1, 1 })]
        public void TestFrequencySort(int[] nums, int[] expected)
        {
            // Arrange
            var solution = new FrequencySort();

            // Act
            var result = solution.Solve(nums);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
