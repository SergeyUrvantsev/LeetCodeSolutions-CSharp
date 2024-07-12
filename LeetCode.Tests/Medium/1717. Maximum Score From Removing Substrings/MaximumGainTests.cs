using LeetCode.Solutions.Medium._1552._Magnetic_Force_Between_Two_Balls;
using LeetCode.Solutions.Medium._1717._Maximum_Score_From_Removing_Substrings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Medium._1717._Maximum_Score_From_Removing_Substrings
{
    public class MaximumGainTests
    {
        [Theory]
        [InlineData("cdbcbbaaabab", 4, 5, 19)]
        [InlineData("aabbaaxybbaabb", 5, 4, 20)]
        public void TestMaximumGain(string s, int x, int y, int expected)
        {
            // Arrange
            var solution = new MaximumGain();

            // Act
            var result = solution.Solve(s, x, y);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
