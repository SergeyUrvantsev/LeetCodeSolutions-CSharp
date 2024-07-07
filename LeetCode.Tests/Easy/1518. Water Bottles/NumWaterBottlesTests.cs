using LeetCode.Solutions.Easy._14._Longest_Common_Prefix;
using LeetCode.Solutions.Easy._1518._Water_Bottles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Easy._1518._Water_Bottles
{
    public class NumWaterBottlesTests
    {
        [Theory]
        [InlineData(9, 3, 13)]
        [InlineData(15, 4, 19)]
        public void TestNumWaterBottles(int numBottles, int numExchange, int expected)
        {
            // Arrange
            var solution = new NumWaterBottles();

            // Act
            var result = solution.Solve(numBottles, numExchange);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
