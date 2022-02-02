namespace LeetCode.Easy;

//BENCHMARK: Speed of Linq's Append() vs Resize or some other mechanism for array manipulation?
/*
 * You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer.
 * The digits are ordered from most significant to least significant in left-to-right order.
 * The large integer does not contain any leading 0's.
 * Increment the large integer by one and return the resulting array of digits.
 */
public static class PlusOne
{
    public static int[] SolutionOne(int[] digits)
    {
        for (var i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] == 9)
            {
                digits[i] = 0;
                continue;
            }

            digits[i]++;
            break;
        }

        if (digits[0] == 0)
        {
            digits = new[] {1}.Concat(digits).ToArray();
        }

        return digits;
    }
}
