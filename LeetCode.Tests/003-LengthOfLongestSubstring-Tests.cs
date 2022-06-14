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
        public void LengthOfLongestSubstring_Examples(string input, int output)
        {
            // Arrange
            var testObj = new _003_LengthOfLongestSubstring();

            // Act
            var result = testObj.LengthOfLongestSubstring(input);

            // Assert
            Assert.Equal(output, result);
        }
    }
}
