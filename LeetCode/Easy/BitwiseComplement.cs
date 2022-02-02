namespace LeetCode.Easy;

public static class BitwiseComplement
{
    public static int GetComplement(int n)
    {
        var bin = Convert.ToString(n, 2);
        var comp = bin.Select(c => c == '1' ? '0' : '1').ToArray();
        return Convert.ToInt32(new string(comp), 2);
    }
}
