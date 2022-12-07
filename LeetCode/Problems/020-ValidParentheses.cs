namespace LeetCode.Problems;

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
