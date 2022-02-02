using LeetCode.Easy;

namespace LeetCode.Tests.Easy;

public class FindTheTownJudgeTests
{
    public static IEnumerable<object[]> FindTheTownJudgeTestData()
    {
        yield return new object[]
        {
            3,
            new[]
            {
                new[] {1, 3},
                new[] {2, 3},
                new[] {3, 1}
            },
            -1
        };

        yield return new object[]
        {
            4,
            new[]
            {
                new[] {1, 4},
                new[] {2, 4},
                new[] {3, 4}
            },
            4
        };

        yield return new object[]
        {
            5,
            new[]
            {
                new[] {1, 2},
                new[] {3, 2},
                new[] {4, 2},
                new[] {5, 2}
            },
            2
        };

        yield return new object[]
        {
            5,
            new[]
            {
                new[] {1, 2},
                new[] {1, 3},
                new[] {3, 2},
                new[] {4, 2},
                new[] {5, 2}
            },
            2
        };

        yield return new object[]
        {
            2,
            new[]
            {
                new[] {1, 2}
            },
            2
        };
        yield return new object[]
        {
            1,
            new int[][] { },
            1
        };
    }

    [Theory]
    [MemberData(nameof(FindTheTownJudgeTestData))]
    public void FindTheTownJudge_ValidInputs_Success(int n, int[][] input, int expected)
    {
        FindTheTownJudge.Find(n, input).Should().Be(expected);
    }
}
