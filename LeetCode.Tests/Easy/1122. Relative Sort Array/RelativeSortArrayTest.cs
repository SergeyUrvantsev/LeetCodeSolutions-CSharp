using LeetCode.Solutions.Easy._1051._Height_Checker;
using LeetCode.Solutions.Easy._1122._Relative_Sort_Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Easy._1122._Relative_Sort_Array
{
    public class RelativeSortArrayTest
    {
        [Theory]
        [InlineData(new int[] { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 }, new int[] { 2, 1, 4, 3, 9, 6 }, new int[] { 2, 2, 2, 1, 4, 3, 3, 9, 6, 7, 19 })]
        [InlineData(new int[] { 28, 6, 22, 8, 44, 17 }, new int[] { 22, 28, 8, 6 }, new int[] { 22, 28, 8, 6, 17, 44 })]
        public void TestRelativeSortArray(int[] arr1, int[] arr2, int[] expected)
        {
            // Arrange
            var solution = new RelativeSortArray();

            // Act
            var result = solution.Solve(arr1, arr2);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
