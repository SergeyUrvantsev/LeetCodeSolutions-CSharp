using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Easy
{
    /// <summary>
    /// 1. Two Sum
    /// </summary>
    public class TwoSum
    {
        public int[] Solve(int[] nums, int target)
        {
            var numDict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numDict.ContainsKey(complement))
                {
                    return new int[] { numDict[complement], i };
                }
                numDict[nums[i]] = i;
            }
            throw new ArgumentException("No two sum solution");
        }
    }
}
