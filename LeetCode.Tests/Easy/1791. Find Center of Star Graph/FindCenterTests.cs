using LeetCode.Solutions.Easy._1791._Find_Center_of_Star_Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Easy._1791._Find_Center_of_Star_Graph
{
    public class FindCenterTests
    {

        [Fact]
        public void TestExample1()
        {
            // Arrange
            var solution = new FindCenter();
            var edges = new int[3][];
            edges[0] = new int[] { 1, 2 };
            edges[1] = new int[] { 2, 3 };
            edges[2] = new int[] { 4, 2 };

            // Act
            var result = solution.Solve(edges);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void TestExample2()
        {
            // Arrange
            var solution = new FindCenter();
            var edges = new int[4][];
            edges[0] = new int[] { 1, 2 };
            edges[1] = new int[] { 5, 1 };
            edges[2] = new int[] { 1, 3 };
            edges[3] = new int[] { 1, 4 };

            // Act
            var result = solution.Solve(edges);

            // Assert
            Assert.Equal(1, result);
        }
    }
}
