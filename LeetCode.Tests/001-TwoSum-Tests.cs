namespace LeetCode.Tests
{
    public class _001_TwoSum_Tests
    {
        [Theory]
        [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
        public void TwoSum_Examples(int[] input, int target, int[] output)
        {
            // Act
            var result = _001_TwoSum.TwoSum(input, target);

            // Assert
            Assert.Equal(output, result);
        }
    }
}
