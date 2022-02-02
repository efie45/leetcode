namespace LeetCode.Easy;

public static class MaxContinguousSubarraySum
{
    public static int FindMaxsum(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }

        var maxSum = int.MinValue;
        var curSum = 0;
        foreach (var val in nums)
        {
            curSum = Math.Max(val, val + curSum);
            maxSum = Math.Max(curSum, maxSum);
        }

        return maxSum;
    }
}
