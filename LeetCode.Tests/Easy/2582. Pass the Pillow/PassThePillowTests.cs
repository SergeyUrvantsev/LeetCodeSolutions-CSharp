using LeetCode.Solutions.Easy._2037._Minimum_Number_of_Moves_to_Seat_Everyone;
using LeetCode.Solutions.Easy._2582._Pass_the_Pillow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Easy._2582._Pass_the_Pillow
{
    public class PassThePillowTests
    {
        [Theory]
        [InlineData(4, 5, 2)]
        [InlineData(3, 2, 3)]
        public void TestPassThePillow(int n, int time, int expected)
        {
            // Arrange
            var solution = new PassThePillow();

            // Act
            var result = solution.Solve(n, time);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
