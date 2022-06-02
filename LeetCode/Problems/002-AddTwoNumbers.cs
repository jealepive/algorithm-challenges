using LeetCode.Common;

namespace LeetCode.Problems
{
    /*
     * You are given two non-empty linked lists representing two non-negative integers.
     * The digits are stored in reverse order, and each of their nodes contains a single digit.
     * Add the two numbers and return the sum as a linked list.
     *
     * You may assume the two numbers do not contain any leading zero, except the number 0 itself.
     *
     * Runtime: 156 ms
     * Memory Usage: 39 MB
     * Submission: https://leetcode.com/submissions/detail/712485789/
     *
    */

    public class _002_AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var output = new ListNode();
            var currentNode1 = l1;
            var currentNode2 = l2;
            var currentOutput = output;
            var overflowCount = 0;
            var nodeSum = 0;
            var hasOverflow = false;

            while (currentNode1 is not null && currentNode2 is not null)
            {
                nodeSum = currentNode1.val + currentNode2.val + overflowCount;
                hasOverflow = nodeSum > 9;

                if (hasOverflow)
                {
                    currentOutput.val = nodeSum - 10;
                    overflowCount = 1;
                }
                else
                {
                    currentOutput.val = nodeSum;
                    overflowCount = 0;
                }
                currentNode1 = currentNode1.next;
                currentNode2 = currentNode2.next;

                if (currentNode2 is not null || currentNode1 is not null || (currentNode1 is null && currentNode2 is null && hasOverflow))
                {
                    currentOutput.next = new ListNode(overflowCount);
                }
                else
                {
                    currentOutput.next = null;
                }
                currentOutput = currentOutput.next;

                if (currentNode1 is null && currentNode2 is not null)
                {
                    currentNode1 = new ListNode();
                }
                else if (currentNode1 is not null && currentNode2 is null)
                {
                    currentNode2 = new ListNode();
                }
            }
            return output;
        }
    }
}
