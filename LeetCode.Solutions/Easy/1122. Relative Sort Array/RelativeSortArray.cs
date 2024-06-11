using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Easy._1122._Relative_Sort_Array
{
    public class RelativeSortArray
    {
        // Complexity:
        // Time complexity: O(n + m + (n - m) + k log k) = O(n + k log k), где n — общее количество элементов в arr1,
        //  m — количество элементов в arr2, k — количество уникальных элементов в countMap
        // Space complexity: O(1), O(n + k) = O(n), где n — общее количество элементов в arr1

        public int[] Solve(int[] arr1, int[] arr2)
        {
            var countMap = new Dictionary<int, int>();
            var remaining = new List<int>();
            var result = new List<int>();

            foreach (var num in arr1)
            {
                countMap[num] = countMap.GetValueOrDefault(num, 0) + 1;
            }

            foreach (var num in arr2)
            {
                for (int i = 0; i < countMap[num]; i++)
                {
                    result.Add(num);
                }
                countMap.Remove(num);
            }

            foreach (var kvp in countMap)
            {
                for (int i = 0; i < kvp.Value; i++)
                {
                    remaining.Add(kvp.Key);
                }
            }

            remaining.Sort();
            result.AddRange(remaining);

            return result.ToArray();
        }
    }
}
