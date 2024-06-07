using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Medium._648._Replace_Words
{
    public class ReplaceWords
    {
        //Решение нацелено на оптимизацию использования памяти, а не времени выполнения
        //Для оптимизации времени выполнения рекомендуется использовать деревья префиксов

        //Complexity:
        //Time complexity: O(n * m + k * log(k)), где n - количество слов в предложении, 
        //m - средняя длина слова, k - количество слов в словаре.
        //Space complexity: O(k), где k - количество слов в словаре.

        public string Solve(IList<string> dictionary, string sentence)
        {
            var roots = dictionary.ToList();
            roots.Sort();

            return string.Join(" ", sentence.Split(' ')
                .Select(word => roots.Find(root => word.StartsWith(root)) ?? word));
        }
    }
}
