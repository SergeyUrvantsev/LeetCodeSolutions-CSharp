using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Easy._1518._Water_Bottles
{
    public class NumWaterBottles
    {
        //Complexity
        //Time: O(1)
        //Space: O(1)

        public int Solve(int numBottles, int numExchange)
            => numBottles + (numBottles - 1) / (numExchange - 1);
    }
}
