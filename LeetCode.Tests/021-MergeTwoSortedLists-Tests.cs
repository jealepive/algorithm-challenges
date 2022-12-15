using System.Collections;
using FluentAssertions;

namespace LeetCode.Tests;
public class _021_MergeTwoSortedLists_Tests
{
    [Theory]
    [ClassData(typeof(_021_MergeTwoSortedLists_Data))]
    public void MergeTwoSortedLists_Examples(ListNode inputList1, ListNode inputList2, ListNode expected)
    {
        // Act
        var actualResult = _021_MergeTwoSortedLists.MergeTwoLists(inputList1, inputList2);

        // Assert
        _ = actualResult.Should().BeEquivalentTo(expected);
    }

    public class _021_MergeTwoSortedLists_Data : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ListNode(1, new ListNode(2, new ListNode(4))),
                new ListNode(1, new ListNode(3, new ListNode(4))),
                new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4)))))),
            };

            yield return new object[]
            {
                null,
                new ListNode(0),
                new ListNode(0),
            };

            yield return new object[]
            {
                null,
                null,
                null,
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
