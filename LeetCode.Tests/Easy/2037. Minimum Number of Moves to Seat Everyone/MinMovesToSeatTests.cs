using LeetCode.Solutions.Easy._2037._Minimum_Number_of_Moves_to_Seat_Everyone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Easy._2037._Minimum_Number_of_Moves_to_Seat_Everyone
{
    public class MinMovesToSeatTests
    {
        [Theory]
        [InlineData(new int[] { 3, 1, 5 }, new int[] { 2, 7, 4 }, 4)]
        [InlineData(new int[] { 4, 1, 5, 9 }, new int[] { 1, 3, 2, 6 }, 7)]
        [InlineData(new int[] { 2, 2, 6, 6 }, new int[] { 1, 3, 2, 6 }, 4)]
        public void TestMinMovesToSeat(int[] seats, int[] students, int expected)
        {
            // Arrange
            var solution = new MinMovesToSeat();

            // Act
            var result = solution.Solve(seats, students);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
