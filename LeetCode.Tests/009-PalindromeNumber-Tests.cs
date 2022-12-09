using FluentAssertions;

namespace LeetCode.Tests
{
    public class _009_PalindromeNumber_Tests
    {
        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]

        public void PalindromeNumber_Examples(int input, bool expected)
        {
            // Act
            var actualResult = _009_PalindromeNumber.IsPalindrome(input);

            // Assert
            _ = actualResult.Should().Be(expected);
        }
    }
}
