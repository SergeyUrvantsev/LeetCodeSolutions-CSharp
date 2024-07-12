using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Medium._1717._Maximum_Score_From_Removing_Substrings
{
    public class MaximumGain
    {
        //Complexity 
        //Time: O(n), где n - длина s
        //Space: O(1)

        public int Solve(string s, int x, int y)
        {
            int result = 0;

            if (x > y)
            {
                result += RemoveAndScore('a', 'b', x);
                result += RemoveAndScore('b', 'a', y);
            }
            else
            {
                result += RemoveAndScore('b', 'a', y);
                result += RemoveAndScore('a', 'b', x);
            }

            return result;

            int RemoveAndScore(char first, char second, int points)
            {
                var stack = new Stack<char>();
                int score = 0;

                foreach (var c in s)
                {
                    if (stack.Count > 0 && stack.Peek() == first && c == second)
                    {
                        stack.Pop();
                        score += points;
                    }
                    else
                    {
                        stack.Push(c);
                    }
                }

                var arr = stack.ToArray();
                Array.Reverse(arr);
                s = new(arr);

                return score;
            }
        }
    }
}
