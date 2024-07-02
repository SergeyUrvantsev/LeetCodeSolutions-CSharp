using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Easy._350._Intersection_of_Two_Arrays_II
{
    public class Intersect
    {
        //Complexity
        //Time: O(n + m), где n и m — длины массивов nums1 и nums2
        //Space: O(min(n, m)), так как размер карты и результирующего массива определяется меньшим из массивов

        public int[] Solve(int[] nums1, int[] nums2)
        {
            return nums1.Length > nums2.Length
                ? GetIntersection(nums1, nums2)
                : GetIntersection(nums2, nums1);

            int[] GetIntersection(int[] larger, int[] smaller)
            {
                var map = new Dictionary<int, int>();
                foreach (var num in larger)
                {
                    if (map.ContainsKey(num))
                    {
                        map[num]++;
                    }
                    else
                    {
                        map[num] = 1;
                    }
                }

                var intersection = new List<int>();

                foreach (var num in smaller)
                {
                    if (map.ContainsKey(num) && map[num] > 0)
                    {
                        intersection.Add(num);
                        map[num]--;

                        if (map[num] == 0)
                        {
                            map.Remove(num);
                        }
                    }
                }

                return intersection.ToArray();
            }
        }
    }
}
