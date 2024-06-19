using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Medium._1482._Minimum_Number_of_Days_to_Make_m_Bouquets
{
    public class MinDays
    {

        //Complexity:
        //Time complexity: O(n log D), где n это длина bloomDay, D это диапозон дней (max - min). 
        //Space complexity: O(1)

        public int Solve(int[] bloomDay, int m, int k)
        {
            if ((long)m * k > bloomDay.Length)
            {
                return -1;
            }

            int left = 1, right = bloomDay.Max();

            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (CanMakeBouquets(mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;

            bool CanMakeBouquets(int day)
            {
                int bouquets = 0, flowers = 0;

                foreach (var bloom in bloomDay)
                {
                    if (bloom <= day)
                    {
                        flowers++;
                        if (flowers == k)
                        {
                            bouquets++;
                            flowers = 0;
                        }
                    }
                    else
                    {
                        flowers = 0;
                    }

                    if (bouquets >= m)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }
}
