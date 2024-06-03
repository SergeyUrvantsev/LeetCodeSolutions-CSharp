using LeetCode.Solutions.Easy;
using LeetCode.Solutions.Medium._2486._Append_Characters_to_String_to_Make_Subsequence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Medium._2486._Append_Characters_to_String_to_Make_Subsequence
{
    public class AppendCharactersTest
    {
        [Fact]
        public void Solve_ReturnsCorrectIndices_Case1()
        {
            var appendCharacters = new AppendCharacters();
            var result = appendCharacters.Solve("coaching", "coding");
            Assert.Equal(4, result);
        }

        [Fact]
        public void Solve_ReturnsCorrectIndices_Case2()
        {
            var appendCharacters = new AppendCharacters();
            var result = appendCharacters.Solve("abcde", "a");
            Assert.Equal(0, result);
        }

        [Fact]
        public void Solve_ReturnsCorrectIndices_Case3()
        {
            var appendCharacters = new AppendCharacters();
            var result = appendCharacters.Solve("z", "abcde");
            Assert.Equal(5, result);
        }

        [Fact]
        public void Solve_ReturnsCorrectIndices_Case4()
        {
            var appendCharacters = new AppendCharacters();
            var result = appendCharacters.Solve("lbg", "g");
            Assert.Equal(0, result);
        }

        [Fact]
        public void Solve_ReturnsCorrectIndices_Case5()
        {
            var appendCharacters = new AppendCharacters();
            var result = appendCharacters.Solve("vrykt", "rkge");
            Assert.Equal(2, result);
        }
    }
}
