namespace LeetCode.Easy;

public static class FindTheTownJudge
{
    public static int Find(int n, int[][] trust)
    {
        if (n == 1 && trust.Length == 0)
        {
            return 1;
        }

        var trustScores = new int[n + 1];

        foreach (var person in trust)
        {
            trustScores[person[0]]--;
            trustScores[person[1]]++;
        }

        for (var i = 0; i < trustScores.Length; i++)
            if (trustScores[i] == n - 1)
            {
                return i;
            }

        return -1;
    }
}
