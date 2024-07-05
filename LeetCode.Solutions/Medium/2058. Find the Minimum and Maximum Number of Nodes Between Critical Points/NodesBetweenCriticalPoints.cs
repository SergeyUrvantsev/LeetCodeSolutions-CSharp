using LeetCode.Solutions.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Medium._2058._Find_the_Minimum_and_Maximum_Number_of_Nodes_Between_Critical_Points
{
    public class NodesBetweenCriticalPoints
    {
        public int[] Solve(ListNode head)
        {
            if (head == null || head.next == null || head.next.next == null)
            {
                return [-1, -1];
            }

            int minDistance = int.MaxValue, maxDistance = 0;
            int lastCritPos = -1, pos = 1;

            var prev = head.val;
            head = head.next;
            
            while(head.next != null)
            {
                if ((head.val > prev && head.val > head.next.val) ||
                    (head.val < prev && head.val < head.next.val))
                {
                    if (lastCritPos != -1)
                    {
                        minDistance = Math.Min(minDistance, pos - lastCritPos);
                        maxDistance += pos - lastCritPos;
                    }

                    lastCritPos = pos;
                }

                prev = head.val;
                head = head.next;
                pos++;
            }


            return minDistance != int.MaxValue 
                ? [minDistance, maxDistance] : [-1, -1];
        }
    }
}
