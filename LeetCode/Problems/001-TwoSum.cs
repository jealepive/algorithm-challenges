namespace LeetCode.Problems;

/*
 *   Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
 *   You may assume that each input would have exactly one solution, and you may not use the same element twice.
 *   You can return the answer in any order.
 *
 *   Time Complexity: O(n)
 *   Space Complexity: O(n)
 *   Runtime: 154 ms
 *   Memory Usage: 44.7 MB
 *   Submission: https://leetcode.com/problems/two-sum/submissions/864043430/
*/

public class _001_TwoSum
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (map.TryGetValue(target - nums[i], out var complementIndex))
            {
                return new[] { complementIndex, i };
            }

            map.TryAdd(nums[i], i);
        }

        return new[] { 0, 0 };
    }
}
