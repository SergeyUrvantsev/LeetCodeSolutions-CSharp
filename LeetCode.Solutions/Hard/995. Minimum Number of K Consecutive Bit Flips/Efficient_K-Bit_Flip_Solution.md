# Intuition
To solve this problem, we need to flip k consecutive bits in the array to turn all elements into 1s. The challenge is to do this efficiently by minimizing the number of flips and ensuring each flip operation affects the correct positions.

# Approach
1. Traverse through the array while keeping track of the flips needed.
2. Use a boolean array `isFlipped` to mark the positions where flips start.
3. Maintain a `currentFlips` counter to keep track of whether the current position should be flipped based on the flips applied within the last k elements.
4. If the current element is equal to `currentFlips`, it indicates that a flip is needed.
5. If the flip cannot be performed due to out-of-bounds, return -1.
6. Adjust `currentFlips` accordingly when a flip is performed and update the `isFlipped` array.

# Complexity
- Time complexity: \(O(n)\) where \(n\) is the length of the array. Each element is processed a constant number of times.
- Space complexity: \(O(n)\) due to the additional boolean array used to track flips.

# Code
```csharp
public class Solution {
    public int MinKBitFlips(int[] nums, int k) {
        int flips = 0;
        int currentFlips = 0;
        bool[] isFlipped = new bool[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            if (i >= k)
            {
                currentFlips ^= isFlipped[i - k] ? 1 : 0;
            }

            if (nums[i] == currentFlips)
            {
                if (i + k > nums.Length)
                {
                    return -1;
                }

                flips++;
                currentFlips ^= 1;
                isFlipped[i] = true;
            }
        }

        return flips;
    }
}

```