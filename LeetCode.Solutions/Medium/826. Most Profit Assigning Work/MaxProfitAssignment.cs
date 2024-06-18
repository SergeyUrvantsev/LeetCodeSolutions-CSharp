using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Medium._826._Most_Profit_Assigning_Work
{
    public class MaxProfitAssignment
    {
        //Complexity:
        //Time complexity: O(n log n + m log m), где n длина массивов difficulty и profit, а m длина массива workers
        //Space complexity: O(1)

        public int Solve(int[] difficulty, int[] profit, int[] workers)
        {
            Array.Sort(difficulty, profit);
            Array.Sort(workers);

            var maxProfit = 0;
            var workIndex = 0;
            var result = 0;

            foreach (var worker in workers)
            {
                for (;workIndex < difficulty.Length && worker >= difficulty[workIndex]; workIndex++)
                {
                    maxProfit = Math.Max(maxProfit, profit[workIndex]);
                }

                result += maxProfit;
            }

            return result;
        }
    }
}
