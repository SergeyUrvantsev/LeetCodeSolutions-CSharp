using LeetCode.Solutions.Easy._14._Longest_Common_Prefix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Easy._14._Longest_Common_Prefix
{
    public class LongestCommonPrefixTest
    {
        [Theory]
        [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new string[] { "dog", "racecar", "car" }, "")]
        [InlineData(new string[] { "apple", "app", "ape" }, "ap")]
        [InlineData(new string[] { "color", "coast", "come" }, "co")]
        [InlineData(new string[] { "prefix", "preference", "preschool" }, "pre")]
        public void TestLongestCommonPrefix(string[] strs, string expected)
        {
            // Arrange
            LongestCommonPrefix solution = new LongestCommonPrefix();

            // Act
            string result = solution.Solve(strs);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
