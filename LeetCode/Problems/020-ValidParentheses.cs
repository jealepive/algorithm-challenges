namespace LeetCode.Problems;

/*
 *  Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
 *
 *  An input string is valid if:
 *  
 *  Open brackets must be closed by the same type of brackets.
 *  Open brackets must be closed in the correct order.
 *  Every close bracket has a corresponding open bracket of the same type.
 * 
 * 
 * Runtime: 78 ms
 * Memory Usage: 38 MB
 * Submission: https://leetcode.com/problems/valid-parentheses/submissions/855859596/
 * 
 */
public class _020_ValidParentheses
{
    private static readonly char[] openBrackets = { '(', '[', '{' };
    private static readonly char[] closeBrackets = { ')', ']', '}' };
    private static readonly Dictionary<char, char> mapBrackets = new()
    {
        { '(', ')' },
        { '[', ']' },
        { '{', '}' }
    };
    public static bool IsValid(string s)
    {
        if (s.Length <= 1)
        {
            return false;
        }

        if (closeBrackets.Contains(s[0]))
        {
            return false;
        }

        var isValid = true;
        var stack = new Stack<char>();

        for (var i = 0; i < s.Length; i++)
        {
            if (openBrackets.Contains(s[i]))
            {
                stack.Push(s[i]);
            }
            else
            {
                var hasElements = stack.TryPop(out var pendingToClose);
                if (!hasElements || mapBrackets[pendingToClose] != s[i])
                {
                    isValid = false;
                    break;
                }
            }
        }

        return isValid && stack.Count == 0;
    }
}
