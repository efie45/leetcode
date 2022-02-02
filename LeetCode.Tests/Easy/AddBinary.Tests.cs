using LeetCode.Easy;

namespace LeetCode.Tests.Easy;

public class AddBinaryTests
{
    public static IEnumerable<object> AddBinaryTestData()
    {
        yield return new object[] {"1", "11", "100"};
        yield return new object[] {"1010", "1011", "10101"};
        yield return new object[] {"0", "0", "0"};
        yield return new object[] {"1", "0", "1"};
    }

    public static IEnumerable<object> FirstSolutionMissedEdgeCases()
    {
        yield return new object[]
        {
            "10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101",
            "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011"
            //TODO: Find and add answer for missed edge case
        };
    }

    [Theory]
    [MemberData(nameof(AddBinaryTestData))]
    public void AddBinary_FirstSolution_Success(string a, string b, string expected)
    {
        AddBinary.FirstSolution(a, b).Should().Be(expected);
    }

    [Theory]
    [MemberData(nameof(AddBinaryTestData))]
    public void AddBinary_ManualAddition_Success(string a, string b, string expected)
    {
        AddBinary.ManualAddition(a, b).Should().Be(expected);
    }

    [Theory]
    [MemberData(nameof(AddBinaryTestData))]
    public void AddBinary_ManualAdditionBetter_Success(string a, string b, string expected)
    {
        AddBinary.ManualAdditionBetter(a, b).Should().Be(expected);
    }
}
