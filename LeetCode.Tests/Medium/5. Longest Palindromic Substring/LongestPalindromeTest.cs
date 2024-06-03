using LeetCode.Solutions.Medium._5._Longest_Palindromic_Substring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Medium._5._Longest_Palindromic_Substring
{
    public class LongestPalindromeTest
    {
        [Fact]
        public void TestCase1()
        {
            // Arrange
            string s = "babad";
            LongestPalindrome solution = new LongestPalindrome();

            // Act
            string result = solution.Solve(s);

            // Assert
            Assert.True(result == "bab" || result == "aba");
        }

        [Fact]
        public void TestCase2()
        {
            // Arrange
            string s = "cbbd";
            LongestPalindrome solution = new LongestPalindrome();

            // Act
            string result = solution.Solve(s);

            // Assert
            Assert.Equal("bb", result);
        }

        [Fact]
        public void TestSingleCharacter()
        {
            // Arrange
            string s = "a";
            LongestPalindrome solution = new LongestPalindrome();

            // Act
            string result = solution.Solve(s);

            // Assert
            Assert.Equal("a", result);
        }

        [Fact]
        public void TestEmptyString()
        {
            // Arrange
            string s = "";
            LongestPalindrome solution = new LongestPalindrome();

            // Act
            string result = solution.Solve(s);

            // Assert
            Assert.Equal("", result);
        }
    }
}
