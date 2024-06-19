using LeetCode.Solutions.Medium._1482._Minimum_Number_of_Days_to_Make_m_Bouquets;
using LeetCode.Solutions.Medium._8._String_to_Integer__atoi_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Medium._1482._Minimum_Number_of_Days_to_Make_m_Bouquets
{
    public class MinDaysTests
    {
        [Theory]
        [InlineData(new int[] { 1, 10, 3, 10, 2 }, 3, 1, 3)]
        [InlineData(new int[] { 1, 10, 3, 10, 2 }, 3, 2, -1)]
        [InlineData(new int[] { 7, 7, 7, 7, 12, 7, 7 }, 2, 3, 12)]
        [InlineData(new int[] { 1, 10, 2, 9, 3, 8, 4, 7, 5, 6 }, 4, 2, 9)]
        public void TestMinDays(int[] bloomDay, int m, int k, int expected)
        {
            // Arrange
            var solution = new MinDays();

            // Act
            var result = solution.Solve(bloomDay, m, k);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
