# Divide and Conquer Strategy

Divide and conquer is basically "**break it into small parts, solve each, then combine.**" It is a **strategy** widely used in computer science, particularly in algorithms for **sorting** like `Merge Sort` and `Quick Sort`, and **searching** like `Binary Search`.

## Problem

Let's take the **Binary search** algorithm which is an efficient algorithm to find an item in a **sorted list**.

## When to Use
- **Sorted Data**: Works only when the array is sorted.
- **Large Inputs**: Efficient for big lists, reducing time complexity from `O(n)` to `O(log n)`.
- **Faster Lookups**: When searching frequently, Binary Search is much better than a linear scan.

## When Not to Use
-  **Unsorted Data**: If the list is not sorted, binary search won't work.
- **Small Inputs**: For tiny arrays, a simple loop might be faster.
- **Linked Lists**: Binary search needs random access (`O(1)`) for indexing, which linked lists don't support.

## Big O Analysis

### Time Complexity:
- Each step halves the problem, so it's **O(log n)**.
- **Best case**: `O(1)` if the element is found immediately at the middle.
- **Worst case**: `O(log n)` if it keeps dividing until one element remains.

### Space Complexity:
- **Recursive version**: O(log n) due to function calls stored in the call stack.
- **Iterative version (while loop)**: O(1), as it only uses a few variables.
