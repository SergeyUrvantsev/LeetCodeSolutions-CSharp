using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Medium._1509._Minimum_Difference_Between_Largest_and_Smallest_Value_in_Three_Moves
{
    public class MinDifference
    {
        //Complexity:
        //Time complexity: O(n log n), где n это длина nums 
        //Space complexity: O(1)

        public int Solve(int[] nums)
        {
            if (nums.Length <= 4)
                return 0;

            Array.Sort(nums);

            return Math.Min(Math.Min(nums[^1] - nums[3], nums[^2] - nums[2]), 
                            Math.Min(nums[^3] - nums[1], nums[^4] - nums[0]));
        }
    }
}
