// See https://aka.ms/new-console-template for more information

int[] numbers = [117, 11, 40, 18, 51, 24, 29, 36, 12, 45];

int sumThreshold = 150;

int maxLength = MaxLengthSubarrayUnderSum(numbers, sumThreshold);

Console.WriteLine("Maximum length of subarray under sum " + sumThreshold + " is " + maxLength);

int MaxLengthSubarrayUnderSum(int[] source, int sumThreshold)
{
    int left = 0, sum = 0, maxLength = 0;

    for (int right = 0; right < source.Length; right++)
    {
        sum += source[right];

        while (sum > sumThreshold)
        {
            sum -= source[left];
            left++;
        }

        maxLength = Math.Max(maxLength, right - left + 1);
    }

    return maxLength;
}