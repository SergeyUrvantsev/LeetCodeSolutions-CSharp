using LeetCode.Solutions.Easy._1002._Find_Common_Characters;
using LeetCode.Solutions.Easy._27._Remove_Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Easy._27._Remove_Element
{
    public class RemoveElementTests
    {
        [Theory]
        [InlineData(new int[] { 3, 2, 2, 3 }, 3, new int[] { 2, 2 })]
        [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new int[] { 0, 1, 3, 0, 4 })]
        public void TestRemoveElement(int[] nums, int val, int[] expected)
        {
            // Arrange
            var solution = new RemoveElement();

            // Act
            var result = solution.Solve(nums, val);

            // Assert
            Assert.Equal(expected.Length, result);

            AssertArrayContainsElements(nums, expected);
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
