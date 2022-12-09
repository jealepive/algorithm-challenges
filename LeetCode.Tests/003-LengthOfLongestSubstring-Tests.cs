using FluentAssertions;

namespace LeetCode.Tests
{
    public class _003_LengthOfLongestSubstring_Tests
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData("  ", 1)]
        [InlineData("a", 1)]
        [InlineData("au", 2)]
        [InlineData("aab", 2)]
        [InlineData("dvdf", 3)]
        [InlineData("anviaj", 5)]
        [InlineData("asljlj", 4)]
        [InlineData("nfpdmpi", 5)]
        public void LengthOfLongestSubstring_Examples(string input, int expected)
        {
            // Act
            var actualResult = _003_LengthOfLongestSubstring.LengthOfLongestSubstring(input);

            // Assert
            _ = actualResult.Should().Be(expected);
        }
    }
}
