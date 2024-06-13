using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Easy._2037._Minimum_Number_of_Moves_to_Seat_Everyone
{
    public class MinMovesToSeat
    {
        // Complexity:
        // Time: O(n log n), где n - количество элементов в массивах seats и students
        // Space: O(1), так как сортировка происходит на месте и используется только несколько дополнительных переменных

        public int Solve(int[] seats, int[] students)
        {
            Array.Sort(seats);
            Array.Sort(students);

            var moves = 0;

            for (int i = 0; i < seats.Length; i++)
            {
                moves += Math.Abs(seats[i] - students[i]);
            }

            return moves;
        }
    }
}
