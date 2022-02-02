using static LeetCode.TwoSum;

namespace LeetCode.Tests;

public class TwoSumTests
{
        public static IEnumerable<object[]> TwoSumValidInputs()
        {
                yield return new object[] {new[] {2, 3, 4}, 7, new[] {1, 2}};
                yield return new object[] {new[] {2, 3, 4, 8, 11, 23, 56, 24, 66}, 68, new[] {0, 8}};
                yield return new object[] {new[] {2, 3, 4, 8, 11, 23, 56, 24, 66}, 69, new[] {1, 8}};
                yield return new object[] {new[] {3, 3}, 6, new[] {0, 1}};
        }
        public static IEnumerable<object[]> TwoSumInValidInputs()
        {
                yield return new object[] {new[] {2}, 7};
        }

        [Theory]
        [MemberData(nameof(TwoSumValidInputs))]
        public void TwoSum_BruteForce_Success(int[] input, int target, int[] expectedArray)
        {
                TwoSumBruteForce(input, target).Should().Equal(expectedArray);
        }        
        
        [Theory]
        [MemberData(nameof(TwoSumValidInputs))]
        public void TwoSum_SinglePassDict_Success(int[] input, int target, int[] expectedArray)
        {
                TwoSumSinglePassDict(input, target).Should().Equal(expectedArray);
        }
        
        [Theory]
        [MemberData(nameof(TwoSumInValidInputs))]
        public void TwoSum_BruteForce_Fail(int[] input, int target)
        {
                Action act = () => TwoSumBruteForce(input, target);
                act.Should().Throw<ArgumentException>();
        }        
        
        [Theory]
        [MemberData(nameof(TwoSumInValidInputs))]
        public void TwoSum_SinglePassDict_Fail(int[] input, int target)
        {
                Action act = () => TwoSumBruteForce(input, target);
                act.Should().Throw<ArgumentException>();
        }
        
}
