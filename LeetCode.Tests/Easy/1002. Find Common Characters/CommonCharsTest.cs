using LeetCode.Solutions.Easy._1002._Find_Common_Characters;
using LeetCode.Solutions.Easy._9._Palindrome_Number;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Easy._1002._Find_Common_Characters
{
    public class CommonCharsTest
    {
        [Theory]
        [InlineData(new string[] { "bella", "label", "roller" }, new string[] { "e", "l", "l" })]
        [InlineData(new string[] { "cool", "lock", "cook" }, new string[] { "c", "o" })]
        public void TestCommonChars(string[] words, string[] expected)
        {
            // Arrange
            var solution = new CommonChars();

            // Act
            var result = solution.Solve(words);

            // Assert
            Assert.Equal(expected.Length, result.Count);

            AssertArrayContainsElements(expected, expected);
        }

        private void AssertArrayContainsElements(IList<string> actual, string[] expected)
        {
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }
    }
}
