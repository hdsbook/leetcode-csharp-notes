/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 */

// @lc code=start
using System.Text;

// 簡化下面 Solution 的寫法
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
        {
            return "";
        }
        if (strs.Length == 1)
        {
            return strs[0];
        }

        StringBuilder sb = new StringBuilder();

        // find the shortest string
        string shortestStr = strs.OrderBy(s => s.Length).FirstOrDefault();

        // foreach alphabet index
        for (int index = 0; index < shortestStr.Length; index++)
        {
            try
            {
                if (strs.Any(nthStr => nthStr[index] != shortestStr[index]))
                {
                    break;
                }
                sb.Append(shortestStr[index]);
            }
            catch (System.Exception)
            {
                break;
            }
        }
        return sb.ToString();
    }
}
public class Solution2
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
        {
            return "";
        }
        if (strs.Length == 1)
        {
            return strs[0];
        }

        // find the shortest string length
        StringBuilder sb = new StringBuilder();
        int minLength = strs.Min(x => x.Length);

        string firstString = strs[0];
        // foreach alphabet index
        for (int index = 0; index < minLength; index++)
        {
            // foreach string after the second string
            for (int nth = 1; nth < strs.Length; nth++)
            {
                // compare with the first string
                string nthString = strs[nth];
                if (nthString[index] != firstString[index])
                {
                    return sb.ToString();
                }
            }
            sb.Append(firstString[index]);
        }
        return sb.ToString();
    }
}
// @lc code=end

