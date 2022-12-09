using FluentAssertions;

namespace LeetCode.Tests
{
    public class _014_LongestCommonPrefix_Tests
    {
        [Theory]
        [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new string[] { "dog", "racecar", "car" }, "")]
        [InlineData(new string[] { "ab", "a" }, "a")]
        [InlineData(new string[] { "cir", "car" }, "c")]
        public void LongestCommonPrefix_Examples(string[] input, string expected)
        {
            // Act
            var actualResult = _014_LongestCommonPrefix.LongestCommonPrefix(input);

            // Assert
            _ = actualResult.Should().Be(expected);
        }
    }
}
