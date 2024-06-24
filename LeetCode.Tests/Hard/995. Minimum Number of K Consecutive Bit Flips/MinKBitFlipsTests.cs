using LeetCode.Solutions.Hard._502._IPO;
using LeetCode.Solutions.Hard._995._Minimum_Number_of_K_Consecutive_Bit_Flips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Hard._995._Minimum_Number_of_K_Consecutive_Bit_Flips
{
    public class MinKBitFlipsTests
    {
        [Theory]
        [InlineData(new int[] { 0, 1, 0 }, 1, 2)]
        [InlineData(new int[] { 1, 1, 0 }, 2, -1)]
        [InlineData(new int[] { 0, 0, 0, 1, 0, 1, 1, 0 }, 3, 3)]
        public void TestMinKBitFlips(int[] nums, int k, int expected)
        {
            // Arrange
            var solution = new MinKBitFlips();

            // Act
            var result = solution.Solve(nums, k);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
