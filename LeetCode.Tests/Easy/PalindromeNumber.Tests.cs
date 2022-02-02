namespace LeetCode.Tests.Easy;

public class PalindromeTests
{
    public static IEnumerable<object[]> IsPalindromeTestData()
    {
        yield return new object[] {0, true};
        yield return new object[] {-1, false};
        yield return new object[] {-121, false};
        yield return new object[] {120, false};
        yield return new object[] {121, true};
        yield return new object[] {189981, true};
        yield return new object[] {189981, true};
        yield return new object[] {1899981, true};
        yield return new object[] {1899812, false};
    }

    [Theory]
    [MemberData(nameof(IsPalindromeTestData))]
    public void IsPalindrome_ValidInputs_Success(int input, bool expected)
    {
        PalindromeNumber.IsPalindrome(input).Should().Be(expected);
    }
}
