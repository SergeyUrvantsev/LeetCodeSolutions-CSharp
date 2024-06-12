using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Medium._75._Sort_Colors
{
    public class SortColors
    {
        //Complexity:
        //Time complexity: O(n), где n это длина массива nums
        //Space complexity: O(1)

        public void Solve(int[] nums)
        {
            int count0 = 0, count1 = 0, count2 = 0;

            foreach (int num in nums)
            {
                switch (num)
                {
                    case 0:
                        count0++;
                        break;
                    case 1:
                        count1++;
                        break;
                    case 2:
                        count2++;
                        break;
                }
            }

            int index = 0;
            for (int i = 0; i < count0; i++)
            {
                nums[index++] = 0;
            }
            for (int i = 0; i < count1; i++)
            {
                nums[index++] = 1;
            }
            for (int i = 0; i < count2; i++)
            {
                nums[index++] = 2;
            }
        }
    }
}
