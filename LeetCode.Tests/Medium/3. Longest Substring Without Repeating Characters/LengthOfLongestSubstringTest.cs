using LeetCode.Solutions.Medium._3._Longest_Substring_Without_Repeating_Characters;
using LeetCode.Solutions.Medium._6._Zigzag_Conversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Medium._3._Longest_Substring_Without_Repeating_Characters
{
    public class LengthOfLongestSubstringTest
    {
        [Fact]
        public void Solve_ReturnsCorrectIndices_Case1()
        {
            var lengthOfLongestSubstring = new LengthOfLongestSubstring();
            var result = lengthOfLongestSubstring.Solve("abcabcbb");
            Assert.Equal(3, result);
        }

        [Fact]
        public void Solve_ReturnsCorrectIndices_Case2()
        {
            var lengthOfLongestSubstring = new LengthOfLongestSubstring();
            var result = lengthOfLongestSubstring.Solve("bbbbb");
            Assert.Equal(1, result);
        }

        [Fact]
        public void Solve_ReturnsCorrectIndices_Case3()
        {
            var lengthOfLongestSubstring = new LengthOfLongestSubstring();
            var result = lengthOfLongestSubstring.Solve("pwwkew");
            Assert.Equal(3, result);
        }
    }
}
