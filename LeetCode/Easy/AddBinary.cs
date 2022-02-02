namespace LeetCode.Easy;

public static class AddBinary
{
    // BENCHMARK: different approaches. Stringbuilder vs char[]?
    // TODO: Doesn't work for very large binary strings like:
    // "10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101" +
    // "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011"

    public static string FirstSolution(string a, string b)
    {
        // Fails for very large values
        // TODO: How would you know what the largest value is that it would fail at without running?
        // TODO: Calculate complexity
        return Convert.ToString(Convert.ToUInt32(a, 2) + Convert.ToUInt32(b, 2), 2);
    }

    public static string ManualAddition(string a, string b)
    {
        var aSpan = a.ToCharArray();
        var bSpan = b.ToCharArray();

        var aPointer = a.Length - 1;
        var bPointer = b.Length - 1;

        var answer = new List<char>();
        var carry = 0;

        while (aPointer >= 0 || bPointer >= 0)
        {
            var aVal = aPointer < 0 ? 0 : aSpan[aPointer] == '0' ? 0 : 1;
            var bVal = bPointer < 0 ? 0 : bSpan[bPointer] == '0' ? 0 : 1;
            var cur = aVal + bVal + carry;
            switch (cur)
            {
                case 0:
                    carry = 0;
                    answer.Add('0');
                    break;
                case 1:
                    carry = 0;
                    answer.Add('1');
                    break;
                case 2:
                    carry = 1;
                    answer.Add('0');
                    break;
                case 3:
                    carry = 1;
                    answer.Add('1');
                    break;
            }

            aPointer--;
            bPointer--;
        }

        if (carry == 1)
        {
            answer.Add('1');
        }

        answer.Reverse();
        return new string(answer.ToArray());
    }

    public static string ManualAdditionBetter(string a, string b)
    {
        var aSpan = a.AsSpan();
        var bSpan = b.AsSpan();

        var aPointer = a.Length - 1;
        var bPointer = b.Length - 1;

        var answer = new char[1 + Math.Max(aSpan.Length, bSpan.Length)];
        var answerIndex = answer.Length - 1;

        var carry = 0;

        while (aPointer >= 0 || bPointer >= 0)
        {
            var aVal = aPointer < 0 ? 0 : aSpan[aPointer] == '0' ? 0 : 1;
            var bVal = bPointer < 0 ? 0 : bSpan[bPointer] == '0' ? 0 : 1;
            var cur = aVal + bVal + carry;

            carry = cur >= 2 ? 1 : 0;
            answer[answerIndex] = cur % 2 == 0 ? '0' : '1';

            aPointer--;
            bPointer--;
            answerIndex--;
        }

        if (carry == 1)
        {
            answer[answerIndex] = '1';
        }

        return new string(answer[0] == '\0' ? answer[1..] : answer);
    }
}
