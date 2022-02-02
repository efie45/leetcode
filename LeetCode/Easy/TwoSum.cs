namespace LeetCode;

public static class TwoSum
{
    /*
     *   https://leetcode.com/problems/two-sum/
     * 
     *   Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
     *
     *   You may assume that each input would have exactly one solution, and you may not use the same element twice.
     *
     *   You can return the answer in any order.
    */

    public static int[] TwoSumBruteForce(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
        for (var j = 0; j < nums.Length; j++)
        {
            if (i == j)
            {
                continue;
            }

            if (nums[i] + nums[j] == target)
            {
                return new[] {i, j};
            }
        }

        throw new ArgumentException("No valid solution exists.");
    }

    public static int[] TwoSumSinglePassDict(int[] nums, int target)
    {
        var valueIndexMap = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            valueIndexMap.TryAdd(nums[i], i);
            var remainder = target - nums[i];
            if (valueIndexMap.TryGetValue(remainder, out var remainderIndex))
            {
                if (i == remainderIndex)
                {
                    continue;
                }

                return new[] {remainderIndex, i};
            }
        }

        throw new ArgumentException("No valid solution exists.");
    }
}
