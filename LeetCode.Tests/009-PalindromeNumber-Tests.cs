namespace LeetCode.Tests
{
    public class _009_PalindromeNumber_Tests
    {
        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]

        public void PalindromeNumber_Examples(int input, bool output)
        {
            // Act
            var result = _009_PalindromeNumber.IsPalindrome(input);

            // Assert
            Assert.Equal(output, result);
        }
    }
}
