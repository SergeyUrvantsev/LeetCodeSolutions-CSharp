using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Easy._20._Valid_Parentheses
{
    public class ValidParentheses
    {
        //Complexity
        //Time: O(n), где n - длина входной строки.
        //Space: O(n), где n - длина входной строки.

        public bool Solve(string s)
        {
            var stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char top = stack.Pop();
                    if (!AreBracketsMatching(top, c))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        private static bool AreBracketsMatching(char opening, char closing)
        {
            return (opening == '(' && closing == ')') ||
                   (opening == '{' && closing == '}') ||
                   (opening == '[' && closing == ']');
        }
    }
}
