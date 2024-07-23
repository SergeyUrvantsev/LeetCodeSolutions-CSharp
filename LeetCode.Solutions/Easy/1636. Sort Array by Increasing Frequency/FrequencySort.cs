using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Easy._1636._Sort_Array_by_Increasing_Frequency
{
    public class FrequencySort
    {
        //Complexity
        //Time: O(n log n), в худшем случае
        //Space: O(n)

        public int[] Solve(int[] nums)
            =>  nums.GroupBy(x => x)  //O(n)
                    .OrderBy(g => g.Count()) //O(m log m)  
                    .ThenByDescending(g => g.Key)  //O(m log m)  
                    .SelectMany(g => g) //O(n)
                    .ToArray(); //O(n)
    }
}
