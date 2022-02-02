namespace LeetCode;

public class PalindromeNumber
{
    /*
     * https://leetcode.com/problems/palindrome-number/
     *
     * Given an integer x, return true if x is palindrome integer.
     *   An integer is a palindrome when it reads the same backward as forward.
     * 
     * For example, 121 is a palindrome while 123 is not.
     */
    public static bool IsPalindrome(int number)
    {
        if (number < 0) return false;
        var numList = new List<int>();

        while (number >= 10)
        {
            var cur = number % 10;
            numList.Add(cur);
            number = (number - cur) / 10;
        }
        numList.Add(number);

        var hi = numList.Count - 1;
        var low = 0;

        while (hi > low)
        {
            if (numList[hi] != numList[low])
                return false;
            
            hi--;
            low++;
        }

        return true;
    }
}
