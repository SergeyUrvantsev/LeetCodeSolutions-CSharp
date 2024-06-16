using LeetCode.Solutions.Hard._330._Patching_Array;
using LeetCode.Solutions.Hard._502._IPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Hard._330._Patching_Array
{
    public class MinPatchesTests
    {
        [Theory]
        [InlineData(new int[] { 1, 3 }, 6, 1)]
        [InlineData(new int[] { 1, 5, 10 }, 20, 2)]
        [InlineData(new int[] { 1, 2, 2 }, 5, 0)]
        [InlineData(new int[] { 1, 2, 31, 33 }, 2147483647, 28)]
        public void TestMinPatches(int[] nums, int n, int expected)
        {
            // Arrange
            var solution = new MinPatches();

            // Act
            var result = solution.Solve(nums, n);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
