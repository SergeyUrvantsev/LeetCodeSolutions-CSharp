using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Easy._1051._Height_Checker
{
    public class HeightChecker
    {
        // Complexity:
        // Time complexity: O(n), где n - количество элементов в массиве heights.
        // Space complexity: O(1), так как максимальное количество различных значений фиксировано и ограничено.

        public int Solve(int[] heights)
        {
            int[] heightCounts = new int[101];
            foreach (var height in heights)
            {
                heightCounts[height]++;
            }

            int result = 0, currentHeight = 0;
            foreach (var height in heights)
            {
                while (heightCounts[currentHeight] == 0)
                {
                    currentHeight++;
                }

                if (height != currentHeight)
                {
                    result++;
                }

                heightCounts[currentHeight]--;
            }

            GC.Collect();
            return result;
        }
    }
}
