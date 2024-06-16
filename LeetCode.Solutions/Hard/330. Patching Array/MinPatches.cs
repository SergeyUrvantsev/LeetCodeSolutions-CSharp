using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Hard._330._Patching_Array
{
    public class MinPatches
    {
        public int Solve(int[] nums, int n)
        {
            var target = 0l; 
            var patches = 0; 
            var index = 0;

            while (target < n && index < nums.Length && nums[index] <= n)
            {
                while (nums[index] > target + 1 && target < n)
                {
                    target += target + 1;
                    patches++;
                }

                target += nums[index];
                index++;
            }

            while(target < n)
            {
                patches++;
                target += target + 1;
            }

            return patches;
        }
    }
}
