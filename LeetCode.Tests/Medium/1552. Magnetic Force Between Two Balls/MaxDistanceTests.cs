using LeetCode.Solutions.Medium._1482._Minimum_Number_of_Days_to_Make_m_Bouquets;
using LeetCode.Solutions.Medium._1552._Magnetic_Force_Between_Two_Balls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Medium._1552._Magnetic_Force_Between_Two_Balls
{
    public class MaxDistanceTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 7 }, 3, 3)]
        [InlineData(new int[] { 5, 4, 3, 2, 1, 1000000000 }, 2, 999999999)]
        [InlineData(new int[] { 2411, 1459, 1933, 1607, 2, 79, 857, 191, 1009, 311, 2609, 1759, 2089, 2269, 2741, 439, 1297, 1151, 577, 709 }, 11, 162)]
        public void TestMaxDistance(int[] position, int m, int expected)
        {
            // Arrange
            var solution = new MaxDistance();

            // Act
            var result = solution.Solve(position, m);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
