# Analyzing Complexity: Operations for Subsequence Transformation

## Intuition
Think of this problem like putting puzzle pieces together. We're trying to find the easiest way to arrange one set of numbers to fit into another set. It's like finding the longest chain of numbers in one set that can be made from pieces of the other set.

## Approach
First, we make a map that shows where each number from the target set goes in the other set. Then, we look at each number in the second set and check if it's in the target set. If it is, we note down where it should go in the first set. After that, we find the longest chain of numbers in the first set that go in increasing order.

## Complexity
**Time complexity:**
- Building the `indexMap` takes O(target.Length).
- Building `indices` takes O(arr.Length).
- Finding the LIS takes O(arr.Length * log(arr.Length)).
- So, the overall time complexity is O(arr.Length * log(arr.Length)).

**Space complexity:**
- We use additional space for `indexMap`, `indices`, and `lis`, each of size O(arr.Length).
- So, the overall space complexity is O(arr.Length).

# Code
```
public class Solution {
    public int MinOperations(int[] target, int[] arr) {
        Dictionary<int, int> indexMap = new Dictionary<int, int>();
        
        for (int i = 0; i < target.Length; i++) {
            indexMap[target[i]] = i;
        }
        
        List<int> indices = new List<int>();
        
        foreach (var num in arr) {
            if (indexMap.ContainsKey(num)) {
                indices.Add(indexMap[num]);
            }
        }
        
        int maxLength = LongestIncreasingSubsequence(indices.ToArray());
        
        return target.Length - maxLength;
    }
    
    private int LongestIncreasingSubsequence(int[] nums) {
        List<int> lis = new List<int>();
        
        foreach (var num in nums) {
            int index = lis.BinarySearch(num);
            
            if (index < 0) {
                index = Math.Abs(index) - 1;
            }
            
            if (index == lis.Count) {
                lis.Add(num);
            } else {
                lis[index] = num;
            }
        }
        
        return lis.Count;
    }
}
```
