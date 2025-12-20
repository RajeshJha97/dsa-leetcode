/*
Problem: MaxSubArray
Link: https://leetcode.com/problems/maximum-subarray
Approach: Kadane's algorithm
Time: O(n)
Space: O(1)
*/


namespace Arrays;

internal static class MaxSubArray
{
    public static int PrefixSum()
    {
        int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        int[] prefix = new int[nums.Length];

        //calculating prefix array
        prefix[1] = nums[1];
        for (int i = 1; i < nums.Length; i++)
        {
            prefix[i] = prefix[i - 1] + nums[i];
        }

        int maxSum = int.MinValue;
        for (int i = 0;i< prefix.Length; i++)
        {
            for (int j = i; j < prefix.Length; j++)
            {
                int currSum = i > 0 ? prefix[j] - prefix[i - 1] : prefix[j];

                if (currSum > maxSum)
                {
                    maxSum = currSum;
                }
            }
        }

        return maxSum;
    }
}
