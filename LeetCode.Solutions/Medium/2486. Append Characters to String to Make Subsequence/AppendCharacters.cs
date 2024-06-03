using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Medium._2486._Append_Characters_to_String_to_Make_Subsequence
{
    public class AppendCharacters
    {
        public int Solve(string s, string t)
        {
            int sIndex = 0;
            int tIndex = 0;
            int maxLengthDiff = t.Length;

            while (sIndex < s.Length)
            {
                if (s[sIndex] == t[tIndex])
                {
                    if (--maxLengthDiff == 0)
                        return 0;
                    tIndex++;
                }
                sIndex++;
            }

            return maxLengthDiff;
        }
    }
}
