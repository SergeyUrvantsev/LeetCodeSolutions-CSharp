using LeetCode.Solutions.Hard._1713._Minimum_Operations_to_Make_a_Subsequence;
using LeetCode.Solutions.Hard._2285._Maximum_Total_Importance_of_Roads;
using LeetCode.Solutions.Hard._273._Integer_to_English_Words;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Hard._2285._Maximum_Total_Importance_of_Roads
{
    public class MaximumImportanceTests
    {
        [Fact]
        public void Solve_Example_1()
        {
            // Arrange
            var solution = new MaximumImportance();
            var roads = new int[6][];
            roads[0] = new int[] { 0, 1 };
            roads[1] = new int[] { 1, 2 };
            roads[2] = new int[] { 2, 3 };
            roads[3] = new int[] { 0, 2 };
            roads[4] = new int[] { 1, 3 };
            roads[5] = new int[] { 2, 4 };

            // Act
            var result = solution.Solve(5, roads);

            // Assert
            Assert.Equal(43, result);
        }

        [Fact]
        public void Solve_Example_2()
        {
            // Arrange
            var solution = new MaximumImportance();
            var roads = new int[3][];
            roads[0] = new int[] { 0, 3 };
            roads[1] = new int[] { 2, 4 };
            roads[2] = new int[] { 1, 3 };

            // Act
            var result = solution.Solve(5, roads);

            // Assert
            Assert.Equal(20, result);
        }

        [Fact]
        public void Solve_Example_3()
        {
            // Arrange
            var solution = new MaximumImportance();
            var roads = new int[1][];
            roads[0] = new int[] { 0, 1 };

            // Act
            var result = solution.Solve(5, roads);

            // Assert
            Assert.Equal(9, result);
        }
    }
}
