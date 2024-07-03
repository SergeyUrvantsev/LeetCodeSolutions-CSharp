using LeetCode.Solutions.Easy._27._Remove_Element;
using LeetCode.Solutions.Easy._28._Find_the_Index_of_the_First_Occurrence_in_a_String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Easy._28._Find_the_Index_of_the_First_Occurrence_in_a_String
{
    public class StrStrTests
    {
        [Theory]
        [InlineData("sadbutsad", "sad", 0)]
        [InlineData("leetcode", "leeto", -1)]
        [InlineData("sadleetcode", "lee", 3)]
        [InlineData("mississippi", "issip", 4)]
        public void TestStrStr(string haystack, string needle, int expected)
        {
            // Arrange
            var solution = new StrStr();

            // Act
            var result = solution.Solve(haystack, needle);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("sadbutsad", "sad", 0)]
        [InlineData("leetcode", "leeto", -1)]
        [InlineData("sadleetcode", "lee", 3)]
        [InlineData("mississippi", "issip", 4)]
        public void TestStrStr_2(string haystack, string needle, int expected)
        {
            // Arrange
            var solution = new StrStr();

            // Act
            var result = solution.Solve_2(haystack, needle);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
