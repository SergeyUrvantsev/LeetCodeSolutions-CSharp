using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Medium._633._Sum_of_Square_Numbers
{
    public class JudgeSquareSum
    {
        //Complexity:
        //Основной цикл будет выполняться от Sqrt(c) до Sqrt(c)/2. В худшем случае, это будет O(Sqrt(c))
        //Time complexity: O(Sqrt(c)). 
        //Space complexity: O(1)

        public bool Solve(int c)
        {
            if (c < 0) return false;

            var maxA = (int)Math.Sqrt(c);
            var minA = maxA / 2;

            while (maxA >= minA)
            {
                var potentialB = Math.Sqrt(c - maxA * maxA);
                if (potentialB == (int)potentialB)
                    return true;

                maxA--;
            }

            return false;
        }
    }
}
