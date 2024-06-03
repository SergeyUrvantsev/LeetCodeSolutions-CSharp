using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Hard._1713._Minimum_Operations_to_Make_a_Subsequence
{
    public class MinOperations
    {
        public int Solve(int[] target, int[] arr)
        {
            // Создаем словарь для хранения индексов элементов из target
            Dictionary<int, int> indexMap = new Dictionary<int, int>();

            // Заполняем словарь индексами элементов из target
            for (int i = 0; i < target.Length; i++)
            {
                indexMap[target[i]] = i;
            }

            // Создаем список, в котором будем хранить индексы элементов из arr,
            // присутствующих в target
            List<int> indices = new List<int>();

            // Заполняем список indices индексами элементов из arr,
            // присутствующих в target
            foreach (var num in arr)
            {
                if (indexMap.ContainsKey(num))
                {
                    indices.Add(indexMap[num]);
                }
            }

            // Находим длину наибольшей возрастающей подпоследовательности в indices
            int maxLength = LongestIncreasingSubsequence(indices.ToArray());

            // Возвращаем результат: разницу между длиной target и длиной наибольшей
            // возрастающей подпоследовательности в indices
            return target.Length - maxLength;
        }

        // Функция для нахождения длины наибольшей возрастающей подпоследовательности
        private int LongestIncreasingSubsequence(int[] nums)
        {
            // Создаем список, в котором будем хранить элементы возрастающей подпоследовательности
            List<int> lis = new List<int>();

            // Проходим по каждому числу в массиве
            foreach (var num in nums)
            {
                // Используем двоичный поиск, чтобы найти индекс, в который нужно вставить num
                // в lis, чтобы поддерживать возрастающий порядок
                int index = lis.BinarySearch(num);

                // Если индекс отрицательный, это означает, что num не найден в lis.
                // Мы используем Math.Abs(index) - 1 для нахождения индекса, куда нужно вставить num.
                if (index < 0)
                {
                    index = Math.Abs(index) - 1;
                }

                // Если индекс равен длине lis, это означает, что num должен быть добавлен в конец.
                if (index == lis.Count)
                {
                    lis.Add(num);
                }
                else
                {
                    // Иначе заменяем элемент с найденным индексом на num.
                    lis[index] = num;
                }
            }

            // Возвращаем длину lis, которая и будет длиной наибольшей возрастающей подпоследовательности.
            return lis.Count;
        }
    }
}
