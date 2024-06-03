using LeetCode.Solutions.Hard._1713._Minimum_Operations_to_Make_a_Subsequence;
using LeetCode.Solutions.Hard._4._Median_of_Two_Sorted_Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Hard._4._Median_of_Two_Sorted_Arrays
{
    public class FindMedianSortedArraysTest
    {
        [Fact]
        public void Solve_ReturnsCorrectIndices_Case1()
        {
            var findMedianSortedArrays = new FindMedianSortedArrays();
            var result = findMedianSortedArrays.Solve([1, 3], [2]);
            Assert.Equal(2.00000d, result);
        }

        [Fact]
        public void Solve_ReturnsCorrectIndices_Case2()
        {
            var findMedianSortedArrays = new FindMedianSortedArrays();
            var result = findMedianSortedArrays.Solve([1, 2], [3, 4]);
            Assert.Equal(2.50000d, result);
        }
    }
}
