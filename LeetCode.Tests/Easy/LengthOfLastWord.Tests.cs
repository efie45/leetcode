using LeetCode.Easy;

namespace LeetCode.Tests.Easy;

public class LengthOfLastWordTests
{
    public static IEnumerable<object[]> LengthOfLastWordTestData()
    {
        yield return new object[] {"Hello World", 5};
        yield return new object[] {"Hello World   ", 5};
        yield return new object[] {"Hello      World", 5};
        yield return new object[] {"   fly me   to   the moon  ", 4};
        yield return new object[] {"luffy is still joyboy", 6};
        yield return new object[] {" ", 0};
        yield return new object[] {"   ", 0};
        yield return new object[] {"", 0};
        yield return new object[] {"a", 1};
        yield return new object[] {"a ", 1};
        yield return new object[] {"day", 3};
    }

    [Theory]
    [MemberData(nameof(LengthOfLastWordTestData))]
    public void LengthOfLastWord_Find_Success(string s, int expected)
    {
        LengthOfLastWord.Find(s).Should().Be(expected);
    }

    [Theory]
    [MemberData(nameof(LengthOfLastWordTestData))]
    public void LengthOfLastWord_FindWithForLoop_Success(string s, int expected)
    {
        LengthOfLastWord.FindWithForLoop(s).Should().Be(expected);
    }
}
