using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Medium._7._Reverse_Integer
{
    public class ReverseInteger
    {

        //Complexity:
        //Time complexity: O(Log10(x)), Количество цифр в x = Log10(x)
        //Space complexity: O(1)

        public int Solve(int x)
        {
            long result = 0;
            while (x != 0)
            {
                result = result * 10 + x % 10;
                x /= 10;
            }

            if (result > int.MaxValue || result < int.MinValue)
            {
                return 0;
            }

            return (int)result;
        }
    }
}
