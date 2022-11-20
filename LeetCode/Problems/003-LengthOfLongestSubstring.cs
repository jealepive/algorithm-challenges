namespace LeetCode.Problems
{
    public class _003_LengthOfLongestSubstring
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            if (s.Length is 1)
            {
                return 1;
            }

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] != s[0])
                {
                    break;
                }

                if (i == s.Length - 1)
                {
                    return 1;
                }
            }

            var longestSubstring = 0;
            var lastElementIndex = s.Length - 1;
            var currentSubString = new List<char>();
            var lastDuplicatedElementIndex = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (!currentSubString.Contains(s[i]) && i != lastElementIndex)
                {
                    currentSubString.Add(s[i]);
                }
                else if (!currentSubString.Contains(s[i]) && i == lastElementIndex)
                {
                    currentSubString.Add(s[i]);
                    if (currentSubString.Count > longestSubstring)
                    {
                        longestSubstring = currentSubString.Count;
                    }
                }
                else if (currentSubString.Contains(s[i]) && i == lastElementIndex)
                {
                    if (currentSubString.Count > longestSubstring)
                    {
                        longestSubstring = currentSubString.Count;
                    }

                    break;
                }
                else
                {
                    i = s.IndexOf(s[i], startIndex: lastDuplicatedElementIndex);
                    lastDuplicatedElementIndex = i;

                    if (currentSubString.Count > longestSubstring)
                    {
                        longestSubstring = currentSubString.Count;
                        currentSubString = new List<char>();
                    }
                }
            }
            return longestSubstring;
        }
    }
}
