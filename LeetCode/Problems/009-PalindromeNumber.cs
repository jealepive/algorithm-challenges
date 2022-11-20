namespace LeetCode.Problems;

/*
 *  Given an integer x, return true if x is a palindrome, and false otherwise. 
 *  
 *  Runtime: 39 ms
 *  Memory Usage: 30 MB
 *  Submission: https://leetcode.com/submissions/detail/847126844/
*/

public class _009_PalindromeNumber
{
    public static bool IsPalindrome(int x)
    {
        var input = x.ToString();
        var i = 0;
        var isPalindrome = false;

        while (i != input.Length - (1 / 2))
        {
            isPalindrome = input[i] == input[input.Length - 1 - i];
            if (!isPalindrome)
            {
                return isPalindrome;
            }

            i++;
        }

        return isPalindrome;
    }
}
