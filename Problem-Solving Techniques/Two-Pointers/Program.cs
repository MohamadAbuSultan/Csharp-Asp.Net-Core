int[] heights = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

System.Console.WriteLine("Max Area using Brute Force: " + MaxAreaContainerAreaUsingBruteForce(heights));
System.Console.WriteLine("Max Area using Two Pointers: " + MaxAreaContainerAreaUsingTwoPointers(heights));

int MaxAreaContainerAreaUsingTwoPointers(int[] heights)
{
    int left = 0;
    int right = heights.Length - 1;
    int maxArea = 0;

    while (left < right)
    {
        int currentArea = Math.Min(heights[left], heights[right]) * (right - left);
        maxArea = Math.Max(maxArea, currentArea);

        if (heights[left] < heights[right])
        {
            left++;
        }
        else
        {
            right--;
        }
    }

    return maxArea;
}

int MaxAreaContainerAreaUsingBruteForce(int[] heights)
{
    int maxArea = 0;
    for (int i = 0; i < heights.Length; i++)
    {
        for (int j = i + 1; j < heights.Length; j++)
        {
            int currentArea = Math.Min(heights[i], heights[j]) * (j - i);
            maxArea = Math.Max(maxArea, currentArea);
        }
    }
    return maxArea;
}
