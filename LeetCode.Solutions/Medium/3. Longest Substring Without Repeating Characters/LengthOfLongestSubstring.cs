using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Medium._3._Longest_Substring_Without_Repeating_Characters
{
    public class LengthOfLongestSubstring
    {
        public int Solve(string s)
        {
            int n = s.Length;
            int maxLength = 0;
            int left = 0;
            Dictionary<char, int> charIndexMap = new Dictionary<char, int>();

            for (int right = 0; right < n; right++)
            {
                if (charIndexMap.ContainsKey(s[right]) && charIndexMap[s[right]] >= left)
                {
                    left = charIndexMap[s[right]] + 1;
                }

                charIndexMap[s[right]] = right;
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}
