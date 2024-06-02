using LeetCode.Solutions.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Easy
{
    public class TwoSumTest
    {
        [Fact]
        public void Solve_ReturnsCorrectIndices_Case1()
        {
            var twoSum = new TwoSum();
            var result = twoSum.Solve(new int[] { 2, 7, 11, 15 }, 9);
            Assert.Equal(new int[] { 0, 1 }, result);
        }

        [Fact]
        public void Solve_ReturnsCorrectIndices_Case2()
        {
            var twoSum = new TwoSum();
            var result = twoSum.Solve(new int[] { 3, 2, 4 }, 6);
            Assert.Equal(new int[] { 1, 2 }, result);
        }

        [Fact]
        public void Solve_ReturnsCorrectIndices_Case3()
        {
            var twoSum = new TwoSum();
            var result = twoSum.Solve(new int[] { 3, 3 }, 6);
            Assert.Equal(new int[] { 0, 1 }, result);
        }

        [Fact]
        public void Solve_ReturnsCorrectIndices_ForNegativeNumbers()
        {
            var twoSum = new TwoSum();
            var result = twoSum.Solve(new int[] { -1, -2, -3, -4, -5 }, -8);
            Assert.Equal(new int[] { 2, 4 }, result);
        }

        [Fact]
        public void Solve_ThrowsException_WhenNoSolution()
        {
            var twoSum = new TwoSum();
            Assert.Throws<ArgumentException>(() => twoSum.Solve(new int[] { 1, 2, 3 }, 7));
        }
    }
}
