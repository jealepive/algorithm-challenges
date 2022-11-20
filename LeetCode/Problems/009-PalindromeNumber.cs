namespace LeetCode.Problems;

/*
 *  Given an integer x, return true if x is a palindrome, and false otherwise. 
 *  
 *  Runtime: 85 ms
 *  Memory Usage: 30 MB
 *  Submission: https://leetcode.com/submissions/detail/846696749/
*/

public class _009_PalindromeNumber
{
    public static bool IsPalindrome(int x)
    {
        var input = x.ToString();
        var temp = new string((char[]?)input.Reverse().ToArray());
        return temp.Equals(input);
    }
}
