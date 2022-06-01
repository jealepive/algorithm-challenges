namespace LeetCode
{
    /*
     *   Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
     *   You may assume that each input would have exactly one solution, and you may not use the same element twice.
     *   You can return the answer in any order.
    */

    public class _001_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && i != j)
                    {
                        return new[] { i, j };
                    }
                }
            }

            return new[] { 0, 0 };
        }
    }
}
