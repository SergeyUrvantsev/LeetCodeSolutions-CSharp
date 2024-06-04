using LeetCode.Solutions.Easy._14._Longest_Common_Prefix;
using LeetCode.Solutions.Easy._409._Longest_Palindrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Easy._409._Longest_Palindrome
{
    public class LongestPalindromeTest
    {
        [Theory]
        [InlineData("abccccdd", 7)]
        [InlineData("a", 1)]
        [InlineData("aA", 1)]
        [InlineData("aaeqfq", 5)]
        public void TestLongestCommonPrefix(string str, int expected)
        {
            // Arrange
            LongestPalindrome solution = new LongestPalindrome();

            // Act
            var result = solution.Solve(str);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
