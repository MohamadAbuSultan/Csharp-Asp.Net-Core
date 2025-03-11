# Dynamic Sliding Window Technique

The **Dynamic Sliding Window** technique is used when the window size is not fixed and dynamically adjusts based on a condition. This technique is applied in problems where we need to find the longest, shortest, or optimal subarray based on a certain constraint.

## Real World Applications
- Adaptive Traffic Light Control.
- Dynamic Toll Pricing Based on Congestion.
- Adaptive Rate Limiting.

## Problem
Finds the longest contiguous subarray where the sum of elements does not exceed a given threshold. Uses a variable sliding window approach for optimal O(n) efficiency.

# Big O Analysis

## Time Complexity
`O(n)` You have nested while loops, but why not `O(n²)`?
✔️ Expanding (`right++`) - at most `n` times.  
✔️ Shrinking (`left++`) - at most `n` times.  
✔️ Each element is added once & removed at most once (twice at most).  
✔️**Total Operations:** ≤ 2n → `O(n)` in the worst case.

## Space Complexity
`O(1)`, since only a few variables are used.
