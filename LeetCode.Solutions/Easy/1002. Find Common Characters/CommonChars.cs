using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.Solutions.Easy._1002._Find_Common_Characters
{
    public class CommonChars
    {
        //Complexity
        //Time: O(n), где n это общее количество символов во всех словах
        //Space: O(1), поскольку используемые массивы фиксированного размера

        private const Byte lettersCount = 26;

        public IList<string> Solve(string[] words)
        {
            var charCounts = new Byte[lettersCount];
            var wordCharCounts = new Byte[lettersCount];

            foreach (char chr in words[0])
            {
                charCounts[chr - 'a']++;
            }

            for (var i = 1; i < words.Length; i++)
            {
                foreach (char chr in words[i])
                {
                    wordCharCounts[chr - 'a']++;
                }

                for (var j = Byte.MinValue; j < lettersCount; j++)
                {
                    if (wordCharCounts[j] < charCounts[j])
                        charCounts[j] = wordCharCounts[j];
                    wordCharCounts[j] = Byte.MinValue;
                }
            }

            var result = new List<string>();
            for (var i = Byte.MinValue; i < lettersCount; i++)
            {
                while (!charCounts[i].Equals(Byte.MinValue))
                {
                    result.Add(((char)('a' + i)).ToString());
                    charCounts[i]--;
                }
            }

            return result;
        }
    }
}
