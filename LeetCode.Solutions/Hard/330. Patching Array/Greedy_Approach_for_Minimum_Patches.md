# Intuition
This problem requires efficiently patching gaps in a sequence formed by a sorted integer array `nums` to cover the range [1, n]. Using a greedy algorithm ensures that we always extend the covered range by adding the minimum possible number to `target`.

# Approach
1. **Initialization**: Start with `target` initialized to 0 and `patches` set to 0 to count how many patches are added.
   
2. **Greedy Strategy**: Iterate through `nums` to ensure `target` covers up to `n`. For each number in `nums`:
   - If the current number is less than or equal to `target + 1`, extend `target` by adding this number.
   - If the current number is greater than `target + 1`, add patches to cover the gap using successive increments of `target + 1`.

3. **Final Gap Handling**: After iterating through `nums`, ensure there are no gaps between `target` and `n`. Add patches to fill this gap using successive increments of `target + 1` until `target` reaches or exceeds `n`.

4. **Return `patches`**: Once `target` covers the range [1, n], return the total number of patches added.

# Complexity
- Time complexity: **O(m + log n)**, where `m` is the length of `nums`. This complexity arises from iterating through `nums` and adjusting `target`. The logarithmic component comes from the operations involving `target` and its growth.
  
- Space complexity: **O(1)**. The algorithm uses a constant amount of extra space regardless of the input size, primarily for storing `target`, `patches`, and iterating variables.


# Code
```csharp
public class Solution {
    public int MinPatches(int[] nums, int n) {
        long target = 0l; 
        int patches = 0; 
        int index = 0;

        while (target < n && index < nums.Length && nums[index] <= n)
        {
            while (nums[index] > target + 1 && target < n)
            {
                target += target + 1;
                patches++;
            }

            target += nums[index];
            index++;
        }

        while(target < n)
        {
            patches++;
            target += target + 1;
        }

        return patches;
    }
}
```