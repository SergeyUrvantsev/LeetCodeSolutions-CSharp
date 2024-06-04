using LeetCode.Solutions.Medium._7._Reverse_Integer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Medium._7._Reverse_Integer
{
    public class ReverseIntegerTest
    {
        [Theory]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        [InlineData(2000000003, 0)]
        [InlineData(-2000000003, 0)]
        public void TestReverseInteger(int x, int expected)
        {
            // Arrange
            var solution = new ReverseInteger();

            // Act
            var result = solution.Solve(x);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
