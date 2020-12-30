/*
 * @lc app=leetcode id=5 lang=csharp
 *
 * [5] Longest Palindromic Substring
 */

// @lc code=start
using System;
using System.Text;
public class Solution
{

    /**
     * Manacher's algorithm
     * @see https://blog.crimx.com/2017/07/06/manachers-algorithm/
     */
    public string LongestPalindrome(string s)
    {
        if (s.Length <= 1)
        {
            return s;
        }

        // T：處理過的字串，如：babad => ^#b#a#b#a#d#$
        string T = preprocessString(s);
        int n = T.Length;

        // P：紀錄以各節點為中心時的LPS長度 (Longest Palindrome String)
        int[] P = new int[n];

        int C = 0; // 紀錄目前最右方迴文的中心索引
        int R = 0; // 紀錄目前最右方迴文的最右端點索引

        /**
         * ^#a#b#c#c#b#a#m#k$
         *     m  C  i  R
         */
        for (int i = 1; i < n - 1; i++)
        {
            // 根據 Manacher 理論，若i在以C為中心的迴文範圍中，預先取得 P[i] 最小值
            // 也就是以i為中心的迴文，至少會有多長
            P[i] = 0;
            if (i < R)
            {
                // mirr：i相對C的鏡射位置索引
                int mirr = 2 * C - i; // C - ( i - C )
                P[i] = Math.Min(R - i, P[mirr]);
            }

            // 記算以該節點為中心時的 LPS 長度
            while (T[i + P[i] + 1] == T[i - P[i] - 1])
            {
                P[i]++;
            }

            // 若此迴文範圍超過最右端點 => 將C改至此位置
            if (i + P[i] > R)
            {
                C = i;
                R = i + P[i];
            }
        }

        int maxLen = 0;
        int centerIndex = 0;
        for (int i = 0; i < n - 1; i++)
        {
            if (P[i] > maxLen)
            {
                maxLen = P[i];
                centerIndex = i;
            }
        }

        return s.Substring((centerIndex - 1) / 2 - (maxLen / 2), maxLen);
    }

    private string preprocessString(string s)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("^");
        foreach (char c in s)
        {
            sb.Append("#");
            sb.Append(c);
        }
        sb.Append("#$");
        return sb.ToString();
    }
}
// @lc code=end

