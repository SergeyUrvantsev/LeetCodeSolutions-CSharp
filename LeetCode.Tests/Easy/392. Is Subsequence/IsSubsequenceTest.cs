using LeetCode.Solutions.Easy._392._Is_Subsequence;
using LeetCode.Solutions.Medium._2486._Append_Characters_to_String_to_Make_Subsequence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Easy._392._Is_Subsequence
{
    public class IsSubsequenceTest
    {
        [Fact]
        public void Solve_ReturnsCorrectIndices_Case1()
        {
            var isSubsequence = new IsSubsequence();
            var result = isSubsequence.Solve("abc", "ahbgdc");
            Assert.True(result);
        }

        [Fact]
        public void Solve_ReturnsCorrectIndices_Case2()
        {
            var isSubsequence = new IsSubsequence();
            var result = isSubsequence.Solve("axc", "ahbgdc");
            Assert.False(result);
        }

        [Fact]
        public void Solve_ReturnsCorrectIndices_Case3()
        {
            var isSubsequence = new IsSubsequence();
            var result = isSubsequence.Solve("", "ahbgdc");
            Assert.True(result);
        }

        [Fact]
        public void Solve_ReturnsCorrectIndices_Case4()
        {
            var isSubsequence = new IsSubsequence();
            var result = isSubsequence.Solve("acb", "ahbgdc");
            Assert.False(result);
        }
    }
}
