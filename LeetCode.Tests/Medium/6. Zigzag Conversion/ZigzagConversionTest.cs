using LeetCode.Solutions.Medium._2486._Append_Characters_to_String_to_Make_Subsequence;
using LeetCode.Solutions.Medium._6._Zigzag_Conversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests.Medium._6._Zigzag_Conversion
{
    public class ZigzagConversionTest
    {
        [Fact]
        public void Solve_ReturnsCorrectIndices_Case1()
        {
            var zigzagConversion = new ZigzagConversion();
            var result = zigzagConversion.Solve("PAYPALISHIRING", 3);
            Assert.Equal("PAHNAPLSIIGYIR", result);
        }

        [Fact]
        public void Solve_ReturnsCorrectIndices_Case2()
        {
            var zigzagConversion = new ZigzagConversion();
            var result = zigzagConversion.Solve("PAYPALISHIRING", 4);
            Assert.Equal("PINALSIGYAHRPI", result);
        }

        [Fact]
        public void Solve_ReturnsCorrectIndices_Case3()
        {
            var zigzagConversion = new ZigzagConversion();
            var result = zigzagConversion.Solve("A", 1);
            Assert.Equal("A", result);
        }
    }
}
