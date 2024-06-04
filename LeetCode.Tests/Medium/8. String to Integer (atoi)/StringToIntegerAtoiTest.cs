using LeetCode.Solutions.Medium._7._Reverse_Integer;
using LeetCode.Solutions.Medium._8._String_to_Integer__atoi_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Medium._8._String_to_Integer__atoi_
{
    public class StringToIntegerAtoiTest
    {
        [Theory]
        [InlineData("42", 42)]
        [InlineData(" -042", -42)]
        [InlineData("1337c0d3", 1337)]
        [InlineData("0-1", 0)]
        [InlineData("words and 987", 0)]
        public void TestStringToIntegerAtoi(string x, int expected)
        {
            // Arrange
            var solution = new StringToIntegerAtoi();

            // Act
            var result = solution.Solve(x);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
