using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Easy._13._Roman_to_Integer
{
    public class RomanToInt
    {
        private static readonly Dictionary<char, int> Map = new()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        //Complexity
        //Time: O(n), где n - длина входной строки. Это потому, что мы проходим по каждому символу в строке один раз.
        //Space: O(1), так как мы используем постоянное количество дополнительной памяти для хранения словаря и переменных.

        public int Solve(string s) =>
            s.Select((c, i) => i < s.Length - 1 && Map[c] < Map[s[i + 1]] ? -Map[c] : Map[c]).Sum();
    }
}
