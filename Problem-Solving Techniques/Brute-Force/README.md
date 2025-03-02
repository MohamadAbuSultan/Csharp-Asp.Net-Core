# Brute Force Problem Solving

**Brute force is basically the "I'll try everything".**

## When to Use

- **Small Inputs**: If your problem has a tiny input space (e.g., n < 20), brute force is acceptable.
- **Baseline Testing**: It's useful for verifying the correctness of more optimized algorithms.
- **Simplicity**: When implementation speed matters more than efficiency.

## When Not to Use

- **Large Inputs**: When the input size is large, brute force explodes (exponential or factorial time), making it impractical.
- **Real-Time Needs**: If you need near-instant results, brute force will get you nowhere.

## Big O Analysis
- **Time Complexity:**    
  - Simple array iteration is `O(n)`.
  - Dealing with subset `O(n)²`.
  - Handling permutations `O(n!)`.
  - Breaking early gives Best-cast `O(1)`.
  - Breaking early gives worst-cast `O(n)`.
  - Worst-case scenario is the one to look at.

- **Space Complexity:**  
  - Typically `O(1)` if no extra space is required.
  - Input array is not counted
  - `O(n)` for storing Temp array. 
