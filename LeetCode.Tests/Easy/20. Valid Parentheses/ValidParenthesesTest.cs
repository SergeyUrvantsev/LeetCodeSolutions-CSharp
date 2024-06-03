using LeetCode.Solutions.Easy._20._Valid_Parentheses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Easy._20._Valid_Parentheses
{
    public class ValidParenthesesTest
    {
        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("{[]}", true)]
        [InlineData("[[[]]]", true)]
        [InlineData("[(])", false)]
        [InlineData("((((((())", false)]
        [InlineData("", true)]
        public void TestValidParentheses(string s, bool expected)
        {
            // Arrange
            ValidParentheses solution = new ValidParentheses();

            // Act
            bool result = solution.Solve(s);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
