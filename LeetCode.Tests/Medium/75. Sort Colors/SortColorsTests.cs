using LeetCode.Solutions.Medium._75._Sort_Colors;
using LeetCode.Solutions.Medium._846._Hand_of_Straights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Medium._75._Sort_Colors
{
    public class SortColorsTests
    {
        [Theory]
        [InlineData(new int[] { 2, 0, 2, 1, 1, 0 }, new int[] { 0, 0, 1, 1, 2, 2 })]
        [InlineData(new int[] { 2, 0, 1 }, new int[] { 0, 1, 2 })]
        [InlineData(new int[] { 0 }, new int[] { 0 })]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        [InlineData(new int[] { 2, 2, 1, 1, 0, 0 }, new int[] { 0, 0, 1, 1, 2, 2 })]
        public void TestSortColors(int[] input, int[] expected)
        {
            // Arrange
            var solution = new SortColors();

            // Act
            solution.Solve(input);

            // Assert
            Assert.Equal(expected, input);
        }
    }
}
