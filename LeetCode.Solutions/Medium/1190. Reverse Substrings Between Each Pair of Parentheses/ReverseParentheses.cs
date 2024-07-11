using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Medium._1190._Reverse_Substrings_Between_Each_Pair_of_Parentheses
{
    public class ReverseParentheses
    {
        //Complexity:
        //Time complexity: O(n)
        //Space complexity: O(n)
        public string Solve(string s)
        {
            var stack = new Stack<int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(i);
                }
                else if (s[i] == ')')
                {
                    var start = stack.Pop();
                    var reversed = new string(s.Substring(start + 1, i - start - 1).Reverse().ToArray());
                    s = s.Substring(0, start) + reversed + s.Substring(i + 1);
                    i = start + reversed.Length - 1;
                }
            }

            return s;
        }
    }
}
