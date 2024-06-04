using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Easy._409._Longest_Palindrome
{
    public class LongestPalindrome
    {
        //Complexity
        //Time: O(n), где n это длина строки s. Алгоритм проходит по строке один раз.
        //Space: O(1), хотя HashSet может в худшем случае содержать до всех символов строки,
        //  но количество возможных уникальных символов ограничено
        //  (256 для ASCII, 65536 для Unicode),
        //  поэтому пространственная сложность можно считать постоянной.

        public int Solve(string s)
        {
            var charSet = new HashSet<char>();
            var palindromeLength = 0;

            foreach (char c in s)
            {
                if (charSet.Contains(c))
                {
                    palindromeLength += 2;
                    charSet.Remove(c);
                }
                else
                {
                    charSet.Add(c);
                }
            }

            return palindromeLength + (charSet.Count > 0 ? 1 : 0);
        }
    }
}
