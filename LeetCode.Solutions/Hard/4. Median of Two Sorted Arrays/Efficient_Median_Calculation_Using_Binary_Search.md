# Intuition
We can use binary search to find the median of two sorted arrays. The main idea is to divide the two arrays into two parts in such a way that all elements on the left are smaller than all elements on the right.

# Approach
We start by determining the sizes of the two arrays and ensure that nums1 is the smaller one. Then, we apply binary search to the smaller array, using variables imin and imax to track the range of indices. We also use halfLen variable to determine half of the length of the combined arrays. Next, we find the splitting position i in nums1 such that every element to the left of i is smaller or equal to every element to the right of j in nums2. If this condition isn't met, we adjust the boundaries of binary search. Once we find the correct splitting position, we check for the even or odd condition and find the median accordingly.

# Complexity
- Time complexity: O(log(min(m, n))), where m and n are the sizes of the arrays.

- Space complexity: O(1), as no additional space is required.

# Code
```
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
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
```