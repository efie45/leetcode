namespace LeetCode.Easy;

// OPTIMIZE: Span of chars to avoid new array allocation? Is Regex faster? 
// BENCHMARK
public static class LengthOfLastWord
{
    public static int Find(string s) { return s.TrimEnd(' ').Split(' ')[^1].Length; }

    public static int FindWithForLoop(string s)
    {
        var chars = s.AsSpan();
        var lastCharIndex = -1;
        for (var i = chars.Length - 1; i >= 0; i--)
        {
            if (chars[i] == ' ')
            {
                continue;
            }

            lastCharIndex = i;
            break;
        }

        if (lastCharIndex == 0)
        {
            return 1;
        }

        if (lastCharIndex == -1)
        {
            return 0;
        }

        for (var i = lastCharIndex; i >= 0; i--)
            if (chars[i] == ' ')
            {
                return lastCharIndex - i;
            }

        return lastCharIndex + 1;
    }
}
