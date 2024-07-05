using LeetCode.Solutions.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Medium._2181._Merge_Nodes_in_Between_Zeros
{
    public class MergeNodes
    {
        //Complexity:
        //Time complexity: O(n), где n - количество узлов
        //Space complexity: O(1)

        public ListNode Solve(ListNode head)
        {
            var current = head.next;
            var point = head;
            while (current != null)
            {
                if(current.val != 0)
                {
                    point.val += current.val;
                }
                else if (current.next != null)
                {
                    point = point.next;
                    point.val = 0;
                }
                else
                {
                    point.next = null;
                }

                current = current.next;
            }

            return head;
        }
    }
}
