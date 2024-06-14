using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Medium._945._Minimum_Increment_to_Make_Array_Unique
{
    public class MinIncrementForUnique
    {
        public int Solve(int[] nums)
        {
            Array.Sort(nums);

            var moves = 0;
            var maxNum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] <= maxNum)
                {
                    moves += maxNum - nums[i] + 1;
                    maxNum += 1;
                }
                else
                {
                    maxNum = nums[i];
                }
                
            }

            return moves;
        }
    }
}
