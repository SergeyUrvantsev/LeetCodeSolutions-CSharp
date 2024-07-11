using LeetCode.Solutions.Medium._1190._Reverse_Substrings_Between_Each_Pair_of_Parentheses;
using LeetCode.Solutions.Medium._1509._Minimum_Difference_Between_Largest_and_Smallest_Value_in_Three_Moves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Medium._1190._Reverse_Substrings_Between_Each_Pair_of_Parentheses
{
    public class ReverseParenthesesTests
    {
        [Theory]
        [InlineData("(abcd)", "dcba")]
        [InlineData("(u(love)i)", "iloveu")]
        [InlineData("(ed(et(oc))el)", "leetcode")]
        [InlineData("sxmdll(q)eki(x)", "sxmdllqekix")]
        public void TestReverseParentheses(string nums, string expected)
        {
            // Arrange
            var solution = new ReverseParentheses();

            // Act
            var result = solution.Solve(nums);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
