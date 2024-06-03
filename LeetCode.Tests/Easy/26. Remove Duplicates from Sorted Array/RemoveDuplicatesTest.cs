using LeetCode.Solutions.Easy;
using LeetCode.Solutions.Easy._20._Valid_Parentheses;
using LeetCode.Solutions.Easy._26._Remove_Duplicates_from_Sorted_Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Easy._26._Remove_Duplicates_from_Sorted_Array
{
    public class RemoveDuplicatesTest
    {
        [Fact]
        public void Solve_ReturnsCorrectIndices_Case1()
        {
            // Arrange
            RemoveDuplicates solution = new RemoveDuplicates();
            var nums = new int[] { 1, 1, 2 };

            // Act
            var result = solution.Solve(nums);

            // Assert
            Assert.Equal(2, result);
            AssertArrayContainsElements(nums, new int[] { 1, 2 });
        }

        [Fact]
        public void Solve_ReturnsCorrectIndices_Case2()
        {
            // Arrange
            RemoveDuplicates solution = new RemoveDuplicates();
            var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            // Act
            var result = solution.Solve(nums);

            // Assert
            Assert.Equal(5, result);
            AssertArrayContainsElements(nums, new int[] { 0, 1, 2, 3, 4 });
        }

        private void AssertArrayContainsElements(int[] actual, int[] expected)
        {
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }
    }
}
