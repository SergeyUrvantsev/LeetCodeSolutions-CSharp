using LeetCode.Solutions.Medium._8._String_to_Integer__atoi_;
using LeetCode.Solutions.Medium._826._Most_Profit_Assigning_Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Medium._826._Most_Profit_Assigning_Work
{
    public class MaxProfitAssignmentTests
    {
        [Theory]
        [InlineData(new int[] { 2, 4, 6, 8, 10 }, new int[] { 10, 20, 30, 40, 50 }, new int[] { 4, 5, 6, 7 }, 100)]
        [InlineData(new int[] { 85, 47, 57 }, new int[] { 24, 66, 99 }, new int[] { 40, 25, 25 }, 0)]
        [InlineData(new int[] { 2, 17, 19, 20, 24, 29, 33, 43, 50, 51, 57, 67, 70, 72, 73, 75, 80, 82, 87, 90 }, new int[] { 6, 7, 10, 17, 18, 29, 30, 31, 34, 39, 40, 42, 48, 54, 57, 78, 78, 78, 83, 88 }, new int[] { 12, 9, 11, 41, 11, 87, 48, 6, 48, 93, 76, 73, 7, 50, 55, 97, 47, 33, 46, 10 }, 693)]
        //[InlineData(new int[] { }, new int[] { }, new int[] { }, 42)]
        public void TestMaxProfitAssignment(int[] difficulty, int[] profit, int[] worker, int expected)
        {
            // Arrange
            var solution = new MaxProfitAssignment();

            // Act
            var result = solution.Solve(difficulty, profit, worker);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
