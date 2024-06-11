using LeetCode.Solutions.Easy._1051._Height_Checker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Easy._1051._Height_Checker
{
    public class HeightCheckerTest
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 4, 2, 1, 3 }, 3)]
        [InlineData(new int[] { 5, 1, 2, 3, 4 }, 5)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 0)]
        public void TestHeightChecker(int[] heights, int expected)
        {
            // Arrange
            var solution = new HeightChecker();

            // Act
            var result = solution.Solve(heights);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
