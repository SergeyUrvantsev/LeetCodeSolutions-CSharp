using LeetCode.Solutions.Easy._9._Palindrome_Number;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Easy._9._Palindrome_Number
{
    public class IsPalindromeTest
    {
        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        [InlineData(12321, true)]
        [InlineData(123456789, false)]
        public void TestIsPalindrome_v1(int x, bool expected)
        {
            // Arrange
            IsPalindrome solution = new IsPalindrome();

            // Act
            bool result = solution.Solve_v1(x);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        [InlineData(12321, true)]
        [InlineData(123456789, false)]
        public void TestIsPalindrome_v2(int x, bool expected)
        {
            // Arrange
            IsPalindrome solution = new IsPalindrome();

            // Act
            bool result = solution.Solve_v2(x);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
