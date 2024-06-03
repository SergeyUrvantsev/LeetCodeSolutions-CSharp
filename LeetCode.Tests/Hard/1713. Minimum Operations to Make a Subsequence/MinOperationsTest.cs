using LeetCode.Solutions.Easy._392._Is_Subsequence;
using LeetCode.Solutions.Hard._1713._Minimum_Operations_to_Make_a_Subsequence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Hard._1713._Minimum_Operations_to_Make_a_Subsequence
{
    public class MinOperationsTest
    {
        [Fact]
        public void Solve_ReturnsCorrectIndices_Case1()
        {
            var minOperations = new MinOperations();
            var result = minOperations.Solve([5, 1, 3], [9, 4, 2, 3, 4]);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Solve_ReturnsCorrectIndices_Case2()
        {
            var minOperations = new MinOperations();
            var result = minOperations.Solve([6, 4, 8, 1, 3, 2], [4, 7, 6, 2, 3, 8, 6, 1]);
            Assert.Equal(3, result);
        }
    }
}
