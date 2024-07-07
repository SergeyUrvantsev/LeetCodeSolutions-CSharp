using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Easy._2582._Pass_the_Pillow
{
    public class PassThePillow
    {
        //Complexity
        //Time: O(1)
        //Space: O(1)

        public int Solve(int n, int time)
        {
            return time / (n - 1) % 2 == 0
                ? time % (n - 1) + 1
                : n - time % (n - 1);
        }
    }
}
