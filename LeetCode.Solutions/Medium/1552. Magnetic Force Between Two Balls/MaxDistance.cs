using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Medium._1552._Magnetic_Force_Between_Two_Balls
{
    public class MaxDistance
    {
        //Complexity 
        //Time: O(n log m), где n - длина positions, m - разница между максимальной и минимальной позициями в positions
        //Space: O(1)

        public int Solve(int[] positions, int m)
        {
            // O(n log n)
            Array.Sort(positions);

            int left = 1, mid, right = positions[^1];


            // O(n log m)
            while (left <= right)
            {
                mid = (left + right) / 2;

                if (CanPlaceBalls(mid))
                {
                    left = mid + 1; 
                }
                else
                {
                    right = mid - 1;
                }
            }

            return right;

            // O(n)
            bool CanPlaceBalls(int minDist)
            {
                int count = 1, lastPosition = positions[0];

                for (int i = 0; i < positions.Length; i++)
                {
                    if (positions[i] - lastPosition >= minDist)
                    {
                        count++;
                        lastPosition = positions[i];

                        if (count >= m)
                        {
                            return true;
                        }
                    }
                }

                return false;
            }
        }
    }
}
