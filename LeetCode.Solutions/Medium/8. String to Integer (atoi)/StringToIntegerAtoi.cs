using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Medium._8._String_to_Integer__atoi_
{
    public class StringToIntegerAtoi
    {

        //Complexity:
        //Time complexity: O(n), где n длина строки s
        //Space complexity: O(1)

        public int Solve(string s)
        {
            int res = 0;
            int i = 0;
            bool isNegative = false;

            // Skip leading whitespaces
            while (i < s.Length && s[i] == ' ')
            {
                i++;
            }

            // Handle optional sign
            if (i < s.Length && (s[i] == '-' || s[i] == '+'))
            {
                isNegative = s[i] == '-';
                i++;
            }

            // Process digits and avoid overflow
            while (i < s.Length && char.IsDigit(s[i]))
            {
                int digit = s[i] - '0';

                // Check for overflow
                if (res > (int.MaxValue - digit) / 10)
                {
                    return isNegative ? int.MinValue : int.MaxValue;
                }

                res = res * 10 + digit;
                i++;
            }

            return isNegative ? -res : res;
        }
    }
}
