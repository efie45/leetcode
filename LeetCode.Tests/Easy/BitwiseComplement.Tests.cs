using LeetCode.Easy;

namespace LeetCode.Tests.Easy;

public class BitwiseComplementTests
{
    public static IEnumerable<object[]> BitwiseComplementTestData()
    {
        yield return new object[] {5, 2};
        yield return new object[] {2, 1};
        yield return new object[] {7, 0};
        yield return new object[] {10, 5};
    }

    [Theory]
    [MemberData(nameof(BitwiseComplementTestData))]
    public void BitwiseComplement_ValidInput_Success(int input, int expected)
    {
        BitwiseComplement.GetComplement(input).Should().Be(expected);
    }

    // TODO Learn bitwise operators and math
}
