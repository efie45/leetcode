namespace LeetCode.Tests.Easy;

public class SearchInsertTests
{
    public static IEnumerable<object[]> SearchInsertData()
    {
        yield return new object[] {new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16}, 12, 12};
        yield return new object[] {new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16}, 0, 0};
        yield return new object[] {new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16}, 16, 16};
        yield return new object[] {new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16}, 0, 0};
        yield return new object[] {new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16}, 17, 17};
        yield return new object[] {Array.Empty<int>(), 56, 0};
        yield return new object[] {new[] {12}, 10, 0};
        yield return new object[] {new[] {12}, 13, 1};
        yield return new object[] {new[] {12}, 12, 0};
        yield return new object[] {new[] {3, 9}, 1, 0};
        yield return new object[] {new[] {3, 9}, 3, 0};
        yield return new object[] {new[] {3, 9}, 9, 1};
        yield return new object[] {new[] {3, 9}, 1000, 2};
    }

    [Theory]
    [MemberData(nameof(SearchInsertData))]
    public void Search_ValidInputs_Success(int[] nums, int target, int expected)
    {
        SearchInsert.Search(nums, target).Should().Be(expected);
    }

    [Theory]
    [MemberData(nameof(SearchInsertData))]
    public void SearchWithBuiltInsAndBitwise_ValidInputs_Success(int[] nums, int target, int expected)
    {
        SearchInsert.SearchWithBuiltInAndBitwise(nums, target).Should().Be(expected);
    }
}
