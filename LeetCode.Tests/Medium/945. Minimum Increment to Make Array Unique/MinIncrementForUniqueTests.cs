using LeetCode.Solutions.Medium._846._Hand_of_Straights;
using LeetCode.Solutions.Medium._945._Minimum_Increment_to_Make_Array_Unique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Medium._945._Minimum_Increment_to_Make_Array_Unique
{
    public class MinIncrementForUniqueTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 2 }, 1)]
        [InlineData(new int[] { 3, 2, 1, 2, 1, 7 }, 6)]
        [InlineData(new int[] { 3, 3, 0, 2, 0, 9, 2, 11, 10, 14, 5, 13, 6, 5, 1 }, 21)]
        public void TestMinIncrementForUnique(int[] nums, int expected)
        {
            // Arrange
            var solution = new MinIncrementForUnique();

            // Act
            var result = solution.Solve(nums);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
