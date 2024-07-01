using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Easy._1550._Three_Consecutive_Odds
{
    public class ThreeConsecutiveOdds
    {
        //Complexity
        //Time: O(n * m), где n - длинна массива arr
        //Space: O(1)

        public bool Solve(int[] arr)
        {
            var index = 0;
            foreach (var item in arr)
            {
                if(item % 2 == 1)
                {
                    index++;
                }
                else
                {
                    index = 0;
                }

                if(index == 3)
                {
                    return true;
                }
                    
            }

            return false;
        }
    }
}
