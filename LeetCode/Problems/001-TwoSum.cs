﻿namespace LeetCode.Problems;

/*
 *   Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
 *   You may assume that each input would have exactly one solution, and you may not use the same element twice.
 *   You can return the answer in any order.
 *
 *   Time Complexity: O(n^2)
 *   Space Complexity: O(1)
 *   Runtime: 288 ms
 *   Memory Usage: 42.9 MB
 *   Submission: https://leetcode.com/submissions/detail/711763489/
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
