using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Hard._502._IPO
{
    public class FindMaximizedCapital
    {
        public int Solve(int numberOfProjects, int initialCapital, int[] profits, int[] capitals)
        {
            // Создаем отсортированное множество для доступных проектов с минимальным капиталом
            var availableProjects = new SortedSet<(int capital, int profit, int index)>();

            // Создаем отсортированное множество для прибыльных проектов
            var profitableProjects = new SortedSet<(int profit, int index)>(
                Comparer<(int profit, int index)>
                .Create((a, b) => b.profit == a.profit ? a.index.CompareTo(b.index) : b.profit.CompareTo(a.profit)));

            // Заполняем множество доступных проектов
            for (int i = 0; i < profits.Length; i++)
            {
                availableProjects.Add((capitals[i], profits[i], i));
            }

            int currentCapital = initialCapital;

            // Пытаемся выполнить до numberOfProjects проектов
            for (int i = 0; i < numberOfProjects; i++)
            {
                // Перемещаем доступные проекты в множество прибыльных проектов, если капитал позволяет
                while (availableProjects.Count > 0 && availableProjects.Min.capital <= currentCapital)
                {
                    var project = availableProjects.Min;
                    availableProjects.Remove(project);
                    profitableProjects.Add((project.profit, project.index));
                }

                // Если нет прибыльных проектов для выполнения, выходим из цикла
                if (profitableProjects.Count == 0)
                {
                    break;
                }

                // Выбираем самый прибыльный проект и увеличиваем текущий капитал
                var bestProject = profitableProjects.Min;
                profitableProjects.Remove(bestProject);
                currentCapital += bestProject.profit;
            }

            return currentCapital;
        }
    }
}
