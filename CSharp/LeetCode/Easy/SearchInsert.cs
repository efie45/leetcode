namespace LeetCode;

public static class SearchInsert
{
    /*
     * https://leetcode.com/problems/search-insert-position/
     * 
     * Given a sorted array of distinct integers and a target value, return the index if the target is found.
     * If not, return the index where it would be if it were inserted in order.
     * 
     * You must write an algorithm with O(log n) runtime complexity.
     */

    public static int Search(int[] nums, int target)
    {
        int low = 0, hi = nums.Length - 1;

        while (hi >= low)
        {
            var mid = (hi - low) / 2 + low;
            if (nums[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                hi = mid - 1;
            }
        }

        return low;
    }

    public static int SearchWithBuiltInAndBitwise(int[] nums, int target)
    {
        var foundIndex = Array.BinarySearch(nums, target);
        return foundIndex >= 0 ? foundIndex : ~ foundIndex;
    }
}
