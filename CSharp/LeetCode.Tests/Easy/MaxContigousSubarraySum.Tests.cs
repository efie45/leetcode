using LeetCode.Easy;

namespace LeetCode.Tests.Easy;

public class MaxContigousSubarraySumTests
{
    public static IEnumerable<object> FindMaxSumTestData()
    {
        yield return new object[]
        {
            new[] {-2, 1, -3, 4, -1, 2, 1, -5, 4},
            6
        };

        yield return new object[]
        {
            new[] {1},
            1
        };

        yield return new object[]
        {
            new[] {5, 4, -1, 7, 8},
            23
        };

        yield return new object[]
        {
            new[] {-1, -2, -5},
            -1
        };
    }

    [Theory]
    [MemberData(nameof(FindMaxSumTestData))]
    public void FixMaxSum_LeetCodeExamples_Success(int[] nums, int expected)
    {
        MaxContinguousSubarraySum.FindMaxsum(nums).Should().Be(expected);
    }
}
