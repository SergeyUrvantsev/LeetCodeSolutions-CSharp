using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Medium._5._Longest_Palindromic_Substring
{
    public class LongestPalindrome
    {

        //Complexity 
        //Time: O(n^2), где n - длина входной строки.
        //  Это потому, что для каждого символа в строке мы потенциально расширяемся влево и вправо,
        //  чтобы найти самый длинный палиндром.
        //Space: O(1), так как мы используем постоянное количество памяти для хранения переменных.

        public string Solve(string s)
        {
            int maxLength = 0, startIndex = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int left = i, right = i;

                while (right < s.Length - 1 && s[left] == s[right + 1])
                    right++;

                while (left > 0 && right < s.Length - 1 && s[left - 1] == s[right + 1])
                {
                    left--;
                    right++;
                }

                int currentLength = right - left + 1;
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    startIndex = left;
                }
            }

            return s.Substring(startIndex, maxLength);
        }
    }
}
