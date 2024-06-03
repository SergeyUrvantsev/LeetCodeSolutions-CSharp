using LeetCode.Solutions.Easy._13._Roman_to_Integer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Easy._13._Roman_to_Integer
{
    public class RomanToIntTest
    {
        [Theory]
        [InlineData("III", 3)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        [InlineData("IX", 9)]
        [InlineData("XIV", 14)]
        [InlineData("XL", 40)]
        [InlineData("XC", 90)]
        [InlineData("CD", 400)]
        [InlineData("CM", 900)]
        public void TestRomanToInt(string s, int expected)
        {
            // Arrange
            RomanToInt solution = new RomanToInt();

            // Act
            int result = solution.Solve(s);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
