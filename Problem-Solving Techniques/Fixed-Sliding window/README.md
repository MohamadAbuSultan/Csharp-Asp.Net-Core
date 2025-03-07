# Fixed Sliding Window Technique

The **Fixed Sliding Window** technique is applied to an array or string to efficiently search for subsets within a fixed-sized window.

## Real-World Applications

- **Traffic Congestion Monitoring**: Analyze vehicle counts in a fixed time window.
- **Trend Detection**: Calculate moving averages for stock prices over a fixed period.
- **Fraud Detection**: Track user transactions within a fixed timeframe to detect suspicious activities.
- **Spell Checking Detection**: Compare fixed-length substrings against words.
- **Temperature Monitoring**: Analyze readings over a fixed time window.

## When to Use

- **Continuous Subarrays**: Best for problems requiring a contiguous range.
- **Optimization**: Reduces complexity from `O(n²)` to `O(n)`.

When the window size is a large proportion of the list size, for example, the number of window shifts will be less because each window covers a significant portion of the list.

## When Not to Use

- **Non-contiguous Subsets**: Doesn't work for problems requiring the selection of scattered elements.
