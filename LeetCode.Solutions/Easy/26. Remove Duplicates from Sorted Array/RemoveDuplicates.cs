using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Easy._26._Remove_Duplicates_from_Sorted_Array
{
    public class RemoveDuplicates
    {
        //Complexity
        //Time: O(n), где n - длина массива nums.
        //Space: O(1), в алгоритме используется постоянное количество дополнительной памяти,
        //  независимо от размера входного массива. Bзменения выполняются непосредственно в массиве nums,
        //  а не создаются дополнительные структуры данных или массивы.

        public int Solve(int[] nums)
        {
            var uniqueElementsCount = 1;
            var currentElement = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if(currentElement != nums[i])
                {
                    currentElement = nums[i];

                    if(uniqueElementsCount <= i)
                    {
                        nums[uniqueElementsCount] = currentElement;
                        uniqueElementsCount++;
                    }
                }
            }

            return uniqueElementsCount;
        }
    }
}
