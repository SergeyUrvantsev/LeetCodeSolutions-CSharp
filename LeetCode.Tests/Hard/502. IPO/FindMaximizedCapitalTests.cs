using LeetCode.Solutions.Hard._502._IPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Hard._502._IPO
{
    public class FindMaximizedCapitalTests
    {
        [Theory]
        [InlineData(2, 0, new int[] { 1, 2, 3 }, new int[] { 0, 1, 1 }, 4)]
        [InlineData(3, 0, new int[] { 1, 2, 3 }, new int[] { 0, 1, 2 }, 6)]
        [InlineData(1, 2, new int[] { 1, 2, 3 }, new int[] { 1, 1, 2 }, 5)]
        [InlineData(11, 11, new int[] { 1, 2, 3 }, new int[] { 11, 12, 13 }, 17)]
        public void TestFindMaximizedCapital(int k, int w, int[] profits, int[] capital, int expected)
        {
            // Arrange
            var solution = new FindMaximizedCapital();

            // Act
            var result = solution.Solve(k, w, profits, capital);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
