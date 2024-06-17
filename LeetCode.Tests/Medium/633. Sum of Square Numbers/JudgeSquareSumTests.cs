using LeetCode.Solutions.Medium._633._Sum_of_Square_Numbers;
using LeetCode.Solutions.Medium._846._Hand_of_Straights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Medium._633._Sum_of_Square_Numbers
{
    public class JudgeSquareSumTests
    {
        [Theory]
        [InlineData(5, true)]
        [InlineData(3, false)]
        [InlineData(0, true)]
        [InlineData(4, true)]
        [InlineData(11, false)]
        [InlineData(2147483642, false)]
        public void TestJudgeSquareSum(int c, bool expected)
        {
            // Arrange
            var solution = new JudgeSquareSum();

            // Act
            var result = solution.Solve(c);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
