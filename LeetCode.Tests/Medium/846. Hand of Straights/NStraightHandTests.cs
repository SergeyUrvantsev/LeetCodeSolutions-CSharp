using LeetCode.Solutions.Easy._9._Palindrome_Number;
using LeetCode.Solutions.Medium._846._Hand_of_Straights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Medium._846._Hand_of_Straights
{
    public class NStraightHandTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 6, 2, 3, 4, 7, 8 }, 3, true)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4, false)]
        [InlineData(new int[] { 8, 10, 12 }, 3, false)]
        [InlineData(new int[] { 2, 3, 4, 5, 6, 7, 8, 9 }, 8, true)]
        [InlineData(new int[] { 8, 8, 9, 7, 7, 7, 6, 7, 10, 6 }, 2, true)]
        [InlineData(new int[] { 9, 13, 15, 23, 22, 25, 4, 4, 29, 15, 8, 23, 12, 19, 24, 17, 18, 11, 22, 24, 17, 17, 10, 23, 21, 18, 14, 18, 7, 6, 3, 6, 19, 11, 16, 11, 12, 13, 8, 26, 17, 20, 13, 19, 22, 21, 27, 9, 20, 15, 20, 27, 8, 13, 25, 23, 22, 15, 9, 14, 20, 10, 6, 5, 14, 12, 7, 16, 21, 18, 21, 24, 23, 10, 21, 16, 18, 16, 18, 5, 20, 19, 20, 10, 14, 26, 2, 9, 19, 12, 28, 17, 5, 7, 25, 22, 16, 17, 21, 11 }, 10, false)]
        public void TestNStraightHand_v1(int[] hand, int groupSize, bool expected)
        {
            // Arrange
            var solution = new NStraightHand();

            // Act
            bool result = solution.Solve_v1(hand, groupSize);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 6, 2, 3, 4, 7, 8 }, 3, true)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4, false)]
        [InlineData(new int[] { 8, 10, 12 }, 3, false)]
        [InlineData(new int[] { 2, 3, 4, 5, 6, 7, 8, 9 }, 8, true)]
        [InlineData(new int[] { 8, 8, 9, 7, 7, 7, 6, 7, 10, 6 }, 2, true)]
        [InlineData(new int[] { 9, 13, 15, 23, 22, 25, 4, 4, 29, 15, 8, 23, 12, 19, 24, 17, 18, 11, 22, 24, 17, 17, 10, 23, 21, 18, 14, 18, 7, 6, 3, 6, 19, 11, 16, 11, 12, 13, 8, 26, 17, 20, 13, 19, 22, 21, 27, 9, 20, 15, 20, 27, 8, 13, 25, 23, 22, 15, 9, 14, 20, 10, 6, 5, 14, 12, 7, 16, 21, 18, 21, 24, 23, 10, 21, 16, 18, 16, 18, 5, 20, 19, 20, 10, 14, 26, 2, 9, 19, 12, 28, 17, 5, 7, 25, 22, 16, 17, 21, 11 }, 10, false)]
        public void TestNStraightHand_v2(int[] hand, int groupSize, bool expected)
        {
            // Arrange
            var solution = new NStraightHand();

            // Act
            bool result = solution.Solve_v2(hand, groupSize);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 6, 2, 3, 4, 7, 8 }, 3, true)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4, false)]
        [InlineData(new int[] { 8, 10, 12 }, 3, false)]
        [InlineData(new int[] { 2, 3, 4, 5, 6, 7, 8, 9 }, 8, true)]
        [InlineData(new int[] { 8, 8, 9, 7, 7, 7, 6, 7, 10, 6 }, 2, true)]
        [InlineData(new int[] { 9, 13, 15, 23, 22, 25, 4, 4, 29, 15, 8, 23, 12, 19, 24, 17, 18, 11, 22, 24, 17, 17, 10, 23, 21, 18, 14, 18, 7, 6, 3, 6, 19, 11, 16, 11, 12, 13, 8, 26, 17, 20, 13, 19, 22, 21, 27, 9, 20, 15, 20, 27, 8, 13, 25, 23, 22, 15, 9, 14, 20, 10, 6, 5, 14, 12, 7, 16, 21, 18, 21, 24, 23, 10, 21, 16, 18, 16, 18, 5, 20, 19, 20, 10, 14, 26, 2, 9, 19, 12, 28, 17, 5, 7, 25, 22, 16, 17, 21, 11 }, 10, false)]
        public void TestNStraightHand_v3(int[] hand, int groupSize, bool expected)
        {
            // Arrange
            var solution = new NStraightHand();

            // Act
            bool result = solution.Solve_v3(hand, groupSize);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
