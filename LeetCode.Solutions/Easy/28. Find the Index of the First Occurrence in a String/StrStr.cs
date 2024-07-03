using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Easy._28._Find_the_Index_of_the_First_Occurrence_in_a_String
{
    public class StrStr
    {
        //Complexity
        //Time: O(n + m), где n и m длинна строк haystack и needle
        //Space: O(1)
        public int Solve(string haystack, string needle)
            => haystack.IndexOf(needle);

        //Complexity
        //Time: O(nm), где n и m длинна строк haystack и needle
        //Space: O(1)
        public int Solve_2(string haystack, string needle)
        {
            var index = 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] != needle[index])
                {
                    i -= index;
                    index = 0;
                }
                else if (++index == needle.Length)
                {
                    return i - index + 1;
                }
            }

            return -1;
        }
    }
}
