/*
Problem: MaxSubArray
Link: https://leetcode.com/problems/maximum-subarray
Approach: Kadane's algorithm
Time: O(n)
Space: O(1)

//Appraoch
1.Calculate Current Sum
2.If current Sum is greater then max_As_of sum then assign current_sum to max_As_of
3.If current Sum is less then 0 then assign currentSum to 0
4.if max_As_of is greater then ans then assign ans and return ans

*/


namespace Arrays;

internal static class MaxSubArray
{
    public static int KadaneAlgo()
    {
        int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        int ans = nums[0];
        int max_as_of = nums[0];
        int current_sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            current_sum += nums[i];

            if (current_sum > max_as_of)
                max_as_of = current_sum;

            if (current_sum < 0)
                current_sum = 0;

            if (max_as_of > ans)
                ans = max_as_of;

        }

        return ans;
    }

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
