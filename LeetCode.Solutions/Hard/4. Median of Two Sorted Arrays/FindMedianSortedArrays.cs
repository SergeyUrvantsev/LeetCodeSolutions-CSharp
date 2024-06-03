using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.Hard._4._Median_of_Two_Sorted_Arrays
{
    public class FindMedianSortedArrays
    {
        public double Solve(int[] nums1, int[] nums2)
        {
            int m = nums1.Length, n = nums2.Length;
            if (m > n)
            {
                int[] temp = nums1;
                nums1 = nums2;
                nums2 = temp;
                int tempLen = m;
                m = n;
                n = tempLen;
            }

            int imin = 0, imax = m, halfLen = (m + n + 1) / 2;
            while (imin <= imax)
            {
                int i = (imin + imax) / 2, j = halfLen - i;
                if (i < m && nums2[j - 1] > nums1[i])
                    imin = i + 1;
                else if (i > 0 && nums1[i - 1] > nums2[j])
                    imax = i - 1;
                else
                {
                    int maxLeft = (i == 0) ? nums2[j - 1] :
                                (j == 0) ? nums1[i - 1] : Math.Max(nums1[i - 1], nums2[j - 1]);
                    if ((m + n) % 2 == 1)
                        return maxLeft;
                    int minRight = (i == m) ? nums2[j] :
                                (j == n) ? nums1[i] : Math.Min(nums1[i], nums2[j]);
                    return (maxLeft + minRight) / 2.0;
                }
            }

            return 0.0;
        }
    }
}
