using LeetCode.Solutions.Medium._648._Replace_Words;
using LeetCode.Solutions.Medium._846._Hand_of_Straights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Medium._648._Replace_Words
{
    public class ReplaceWordsTests
    {
        [Theory]
        [InlineData(new string[]{ "cat", "bat", "rat" }, "the cattle was rattled by the battery", "the cat was rat by the bat")]
        [InlineData(new string[] { "a", "b", "c" }, "aadsfasf absbs bbab cadsfafs", "a a b c")]
        [InlineData(new string[] { "catt", "cat", "bat", "rat" }, "the cattle was rattled by the battery", "the cat was rat by the bat")]
        public void TestReplaceWords(string[] dictionary, string sentence, string expected)
        {
            // Arrange
            var solution = new ReplaceWords();

            // Act
            var result = solution.Solve(dictionary.ToList(), sentence);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
