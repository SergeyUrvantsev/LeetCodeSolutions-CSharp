using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Easy._27._Remove_Element
{
    public class RemoveElement
    {
        //Complexity
        //Time: O(n), где n длинна массива nums
        //Space: O(1)

        public int Solve(int[] nums, int val)
        {
            var index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    continue;
                }

                if (index != i)
                {
                    nums[index] = nums[i];
                }

                index++;
            }

            return index;
        }
    }
}
