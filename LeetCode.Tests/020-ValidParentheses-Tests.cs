namespace LeetCode.Tests;

public class _020_ValidParentheses_Tests
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("([)]", false)]
    [InlineData("([{}])", true)]
    [InlineData("((", false)]
    [InlineData("(", false)]
    [InlineData("){", false)]
    public void ValidParentheses_Examples(string input, bool expected)
    {
        // Act
        var actual = _020_ValidParentheses.IsValid(input);

        // Assert
        Assert.Equal(expected, actual);
    }
}
