using LeetCode.Common;

namespace LeetCode.Problems;

/*
 * You are given the heads of two sorted linked lists list1 and list2.
 *
 * Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.
 *
 * Return the head of the merged linked list.
 * 
 * 
 * Runtime: 94 ms
 * Memory Usage: 39.6 MB
 * Submission: https://leetcode.com/problems/merge-two-sorted-lists/submissions/859972047/    
 */
public class _021_MergeTwoSortedLists
{
    public static ListNode? MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 is null && list2 is null)
        {
            return null;
        }

        if (list1 is not null && list1.next is null && list2 is null)
        {
            return new ListNode(list1.val);
        }
        else if (list2 is not null && list2.next is null && list1 is null)
        {
            return new ListNode(list2.val);
        }

        var output = new ListNode();
        var currentNode1 = list1;
        var currentNode2 = list2;
        var currentOutput = output;
        while (currentNode1 is not null || currentNode2 is not null)
        {
            if ((currentNode2?.val is null && currentNode1?.val is not null) || currentNode1?.val <= currentNode2?.val)
            {
                if (output.val == 0 && output.next is null)
                {
                    output = new ListNode(currentNode1.val);
                    currentOutput = output;
                }
                else
                {
                    currentOutput.next = new ListNode(currentNode1.val);
                    currentOutput = currentOutput.next;
                }
                currentNode1 = currentNode1.next;
            }
            else if ((currentNode1?.val is null && currentNode2?.val is not null) || currentNode1?.val > currentNode2?.val)
            {
                if (output.val == 0 && output.next is null)
                {
                    output = new ListNode(currentNode2.val);
                    currentOutput = output;
                }
                else
                {
                    currentOutput.next = new ListNode(currentNode2.val);
                    currentOutput = currentOutput.next;
                }
                currentNode2 = currentNode2.next;
            }
        }

        return output;
    }
}
