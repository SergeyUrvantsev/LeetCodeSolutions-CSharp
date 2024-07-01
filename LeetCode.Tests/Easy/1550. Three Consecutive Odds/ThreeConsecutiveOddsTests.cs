using LeetCode.Solutions.Easy._1051._Height_Checker;
using LeetCode.Solutions.Easy._1550._Three_Consecutive_Odds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Easy._1550._Three_Consecutive_Odds
{
    public class ThreeConsecutiveOddsTests
    {
        [Theory]
        [InlineData(new int[] { 2, 6, 4, 1 }, false)]
        [InlineData(new int[] { 1, 2, 34, 3, 4, 5, 7, 23, 12 }, true)]
        public void TestThreeConsecutiveOdds(int[] heights, bool expected)
        {
            // Arrange
            var solution = new ThreeConsecutiveOdds();

            // Act
            var result = solution.Solve(heights);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
