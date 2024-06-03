using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Easy._392._Is_Subsequence
{
    public class IsSubsequence
    {
        public bool Solve(string s, string t)
        {
            if (s == string.Empty)
                return true;

            int sIndex = 0;
            int tIndex = 0;

            while (tIndex < t.Length)
            {
                if (t[tIndex] == s[sIndex])
                {
                    if (++sIndex == s.Length)
                        return true;
                }
                tIndex++;
            }

            return false;
        }
    }
}
