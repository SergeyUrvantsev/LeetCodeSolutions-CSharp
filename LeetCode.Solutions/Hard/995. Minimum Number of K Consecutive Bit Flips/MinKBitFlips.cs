using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Hard._995._Minimum_Number_of_K_Consecutive_Bit_Flips
{
    public class MinKBitFlips
    {
        public int Solve(int[] nums, int k)
        {
            int flips = 0;
            int currentFlips = 0;
            bool[] isFlipped = new bool[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (i >= k)
                {
                    currentFlips ^= isFlipped[i - k] ? 1 : 0;
                }

                if (nums[i] == currentFlips)
                {
                    if (i + k > nums.Length)
                    {
                        return -1;
                    }

                    flips++;
                    currentFlips ^= 1;
                    isFlipped[i] = true;
                }
            }

            return flips;
        }
    }
}
