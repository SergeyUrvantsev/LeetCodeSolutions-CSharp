using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Easy._1791._Find_Center_of_Star_Graph
{
    public class FindCenter
    {
        //Complexity
        //Time: O(1)
        //Space: O(1)

        public int Solve(int[][] edges)
            => edges[0][1] == edges[1][0] || edges[0][1] == edges[1][1] 
                ? edges[0][1]
                : edges[0][0];
    }
}
