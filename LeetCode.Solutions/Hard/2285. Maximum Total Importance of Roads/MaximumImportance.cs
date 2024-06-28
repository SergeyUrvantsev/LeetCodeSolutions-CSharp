using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Hard._2285._Maximum_Total_Importance_of_Roads
{
    public class MaximumImportance
    {
        //Complexity
        //Time: O(m + n log n), где n - количество городов имеющих хотя бы 1 дорогу, m - количество дорог
        //Space: O(n), где n - количество городов имеющих хотя бы 1 дорогу

        public long Solve(int n, int[][] roads)
        {
            //Space: O(n)
            var roadsMap = new Dictionary<int, int>();

            //Time: O(m) - проход по всем дорогам
            foreach (var road in roads)
            {
                roadsMap[road[0]] = roadsMap.GetValueOrDefault(road[0], 0) + 1;
                roadsMap[road[1]] = roadsMap.GetValueOrDefault(road[1], 0) + 1;
            }


            var value = n - roadsMap.Count + 1;

            //Space: O(n)
            //Time: O(n log n) - сортировка, O(n log n) - преобразование обратно в словарь 
            roadsMap = roadsMap.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => value++);

            var result = 0l;

            //Time: O(m) - проход по всем дорогам
            foreach (var road in roads)
            {
                result += roadsMap[road[0]] + roadsMap[road[1]];
            }

            return result;
        }
    }
}
