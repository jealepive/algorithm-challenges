using System.Collections;
using FluentAssertions;

namespace LeetCode.Tests
{
    public class _002_AddTwoNumbers_Tests
    {
        [Theory]
        [ClassData(typeof(_002_AddTwoNumbers_Data))]
        public void TwoSum_Examples(ListNode l1, ListNode l2, ListNode output)
        {
            // Arrange
            var testObj = new _002_AddTwoNumbers();

            // Act
            var result = testObj.AddTwoNumbers(l1, l2);

            // Assert
            result.Should().BeEquivalentTo(output);
        }
    }

    public class _002_AddTwoNumbers_Data : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {
                new ListNode(2, new ListNode(4, new ListNode(3))),
                new ListNode(5, new ListNode(6, new ListNode(4))),
                new ListNode(7, new ListNode(0, new ListNode(8))),
            };

            yield return new object[] {
                new ListNode(0),
                new ListNode(0),
                new ListNode(0),
            };

            yield return new object[] {
                new ListNode(9, new ListNode(9, new ListNode(9,new ListNode(9,new ListNode(9,new ListNode(9,new ListNode(9))))))),
                new ListNode(9,new ListNode(9,new ListNode(9,new ListNode(9)))),
                new ListNode(8, new ListNode(9,new ListNode(9,new ListNode(9,new ListNode(0,new ListNode(0,new ListNode(0,new ListNode(1)))))))),
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
