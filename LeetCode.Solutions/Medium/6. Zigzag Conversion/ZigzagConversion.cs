using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Medium._6._Zigzag_Conversion
{
    public class ZigzagConversion
    {
        //Complexity:
        //Time complexity: O(n), где n - длина строки. Каждый символ обрабатывается один раз.
        //Space complexity: O(n), для хранения символов в строках.

        public string Solve(string s, int numRows)
        {
            if (numRows == 1 || s.Length <= numRows)
            {
                return s;
            }

            StringBuilder[] rows = new StringBuilder[numRows];
            for (int i = 0; i < numRows; i++)
            {
                rows[i] = new StringBuilder();
            }

            int curRow = 0;
            bool goingDown = false;

            foreach (char c in s)
            {
                rows[curRow].Append(c);
                if (curRow == 0 || curRow == numRows - 1)
                {
                    goingDown = !goingDown;
                }
                curRow += goingDown ? 1 : -1;
            }

            StringBuilder result = new StringBuilder();
            foreach (var row in rows)
            {
                result.Append(row);
            }

            return result.ToString();
        }
    }
}
