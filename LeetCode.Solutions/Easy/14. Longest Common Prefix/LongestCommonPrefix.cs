using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Easy._14._Longest_Common_Prefix
{
    public class LongestCommonPrefix
    {

        //Complexity
        //Time: O(n * m), где n - количество строк в массиве, а m - длина самой короткой строки в массиве.
        //  Мы проходим по каждому символу короткой строки и сравниваем его с символами в других строках.
        //Space: O(1), так как мы используем постоянное количество дополнительной
        //  памяти для хранения переменных.

        public string Solve(string[] strs)
        {
            var result = string.Empty;
            var minLenght = strs.Min(str => str.Length);
            for (int i = 0; i < minLenght; i++)
            {
                for (int j = 0; j < strs.Length - 1; j++)
                {
                    if (strs[j][i] != strs[j + 1][i])
                    {
                        return result;
                    }
                }
                result += strs[0][i];
            }
            return result;
        }
    }
}
