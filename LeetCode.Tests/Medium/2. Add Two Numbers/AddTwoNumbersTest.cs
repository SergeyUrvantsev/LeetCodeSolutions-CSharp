using LeetCode.Solutions.Common;
using LeetCode.Solutions.Medium._2._Add_Two_Numbers;
using LeetCode.Solutions.Medium._6._Zigzag_Conversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Medium._2._Add_Two_Numbers
{
    public class AddTwoNumbersTest
    {
        [Fact]
        public void Solve_ReturnsCorrectIndices_Case1()
        {
            // Arrange
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            var addTwoNumbers = new AddTwoNumbers();

            // Act
            var result = addTwoNumbers.Solve(l1, l2);

            // Assert
            Assert.Equal(7, result.val);
            Assert.Equal(0, result.next.val);
            Assert.Equal(8, result.next.next.val);
        }

        [Fact]
        public void Solve_ReturnsCorrectIndices_Case2()
        {
            // Arrange
            ListNode l1 = new ListNode(0);
            ListNode l2 = new ListNode(0);
            var addTwoNumbers = new AddTwoNumbers();

            // Act
            var result = addTwoNumbers.Solve(l1, l2);

            // Assert
            Assert.Equal(0, result.val);
        }

        [Fact]
        public void Solve_ReturnsCorrectIndices_Case3()
        {
            // Arrange
            ListNode l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            ListNode l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
            var addTwoNumbers = new AddTwoNumbers();

            // Act
            var result = addTwoNumbers.Solve(l1, l2);

            // Assert
            Assert.Equal(8, result.val);
            Assert.Equal(9, result.next.val);
            Assert.Equal(9, result.next.next.val);
            Assert.Equal(9, result.next.next.next.val);
            Assert.Equal(0, result.next.next.next.next.val);
            Assert.Equal(0, result.next.next.next.next.next.val);
            Assert.Equal(0, result.next.next.next.next.next.next.val);
            Assert.Equal(1, result.next.next.next.next.next.next.next.val);
        }
    }
}
