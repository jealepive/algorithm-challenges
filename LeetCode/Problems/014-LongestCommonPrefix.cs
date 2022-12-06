using System.Text;

namespace LeetCode.Problems;

/*
 * Write a function to find the longest common prefix string amongst an array of strings.
 * If there is no common prefix, return an empty string "".
 * 
 * 
 * Runtime: 104 ms
 * Memory Usage: 39.9 MB
 * Submission: https://leetcode.com/problems/longest-common-prefix/submissions/855319326/
*/
public class _014_LongestCommonPrefix
{
    public static string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
        {
            return "";
        }
        else if (strs.Length == 1)
        {
            return strs[0];
        }

        var output = new StringBuilder();
        var setPrefix = new HashSet<char>();
        var isLookupDone = false;
        var i = 0;

        while (!isLookupDone)
        {
            for (var j = 0; j < strs.Length; j++)
            {
                if (i < strs[j].Length)
                {
                    _ = setPrefix.Add(strs[j][i]);

                }
                else
                {
                    isLookupDone = true;
                    setPrefix.Clear();
                    break;
                }
            }

            if (setPrefix.Count == 1)
            {
                _ = output.Append(setPrefix.ElementAt(0));
            }
            else
            {
                break;
            }

            setPrefix.Clear();
            i++;
        }
        return output.ToString();
    }
}


