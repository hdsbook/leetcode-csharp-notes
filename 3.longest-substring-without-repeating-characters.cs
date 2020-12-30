/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */

// @lc code=start
using System;
using System.Collections.Generic;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length <= 1)
        {
            return s.Length;
        }

        int max = 0;
        int right = 0;
        int left = 0;
        HashSet<char> charSet = new HashSet<char>();
        while (right < s.Length)
        {
            char newChar = s[right++];

            // 當目前範圍包含新字元
            while (charSet.Contains(newChar))
            {
                // 從左而右的縮小範圍，直到不含該字元
                charSet.Remove(s[left++]);
            }
            charSet.Add(newChar);
            max = Math.Max(charSet.Count, max);
        }

        return max;
    }
}
public class Solution2
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s == "")
        {
            return 0;
        }

        if (s.Length == 1)
        {
            return 1;
        }

        int max = 0;
        int len = 0;
        int strLength = s.Length;

        for (int i = 0; i < strLength - 1; i++)
        {
            List<char> hash = new List<char>() { s[i] };

            int j = i + 1;
            for (j = i + 1; j < strLength; j++)
            {
                if (hash.Contains(s[j]))
                {
                    break;
                }
                hash.Add(s[j]);
            }
            max = Math.Max(hash.Count, max);
        }
        return max;
    }
}
// @lc code=end

