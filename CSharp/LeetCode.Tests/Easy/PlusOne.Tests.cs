using LeetCode.Easy;

namespace LeetCode.Tests.Easy;

public class PlusOneTests
{
    public static IEnumerable<object> PlusOneTestData()
    {
        yield return new object[]
        {
            new[] {9},
            new[] {1, 0}
        };
        yield return new object[]
        {
            new[] {1, 2, 3},
            new[] {1, 2, 4}
        };
        yield return new object[]
        {
            new[] {9, 9, 9},
            new[] {1, 0, 0, 0}
        };
        yield return new object[]
        {
            new[] {5, 9, 9, 8, 9, 9},
            new[] {5, 9, 9, 9, 0, 0}
        };
    }

    [Theory]
    [MemberData(nameof(PlusOneTestData))]
    public void PlusOne_SolutionOne_Success(int[] digits, int[] expected)
    {
        PlusOne.SolutionOne(digits).Should().Equal(expected);
    }
}
