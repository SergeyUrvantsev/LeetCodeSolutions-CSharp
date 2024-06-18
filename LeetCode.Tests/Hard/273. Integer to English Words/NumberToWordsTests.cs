using LeetCode.Solutions.Hard._273._Integer_to_English_Words;
using LeetCode.Solutions.Hard._502._IPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Hard._273._Integer_to_English_Words
{
    public class NumberToWordsTests
    {
        [Theory]
        [InlineData(123, "One Hundred Twenty Three")]
        [InlineData(12345, "Twelve Thousand Three Hundred Forty Five")]
        [InlineData(1234567, "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven")]
        [InlineData(1000010, "One Million Ten")]
        [InlineData(0, "Zero")]
        public void TestNumberToWords(int num, string expected)
        {
            // Arrange
            var solution = new NumberToWords();

            // Act
            var result = solution.Solve(num);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
