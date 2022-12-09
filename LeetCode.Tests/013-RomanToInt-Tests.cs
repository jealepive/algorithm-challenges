using FluentAssertions;

namespace LeetCode.Tests
{
    public class _013_RomanToInt_Tests
    {
        [Theory]
        [InlineData("III", 3)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        [InlineData("MCMXCVI", 1996)]
        public void RomanToInt_Examples(string input, int expected)
        {
            // Act
            var actualResult = _013_RomanToInt.RomanToInt(input);

            // Assert
            _ = actualResult.Should().Be(expected);
        }
    }
}
