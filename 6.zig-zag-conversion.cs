/*
 * @lc app=leetcode id=6 lang=csharp
 *
 * [6] ZigZag Conversion
 */

// @lc code=start
using System.Text;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows <= 1 || s.Length <= 1 || numRows >= s.Length)
        {
            return s;
        }

        var rows = Enumerable.Range(0, numRows)
            .Select(_ => new List<char>())
            .ToArray();

        int index = 0;
        int dir = 1;
        foreach (char c in s)
        {
            rows[index].Add(c);
            index += dir;
            if (index == 0 || index == numRows - 1)
            {
                dir *= -1;
            }
        }

        StringBuilder sb = new StringBuilder();
        foreach (var row in rows)
        {
            sb.Append(string.Join("", row).ToString());
        }
        return sb.ToString();
    }
}

public class Solution2
{
    public string Convert(string s, int numRows)
    {
        if (numRows <= 1 || s.Length <= 1 || numRows >= s.Length)
        {
            return s;
        }

        var rows = Enumerable.Range(0, numRows)
            .Select(_ => new StringBuilder()) // 改成用 StringBuilder 好像更直接一些
            .ToArray();

        int index = 0;
        int dir = 1;
        foreach (char c in s)
        {
            rows[index].Append(c);
            index += dir;
            if (index == 0 || index == numRows - 1)
            {
                dir *= -1;
            }
        }

        StringBuilder sb = new StringBuilder();
        foreach (var row in rows)
        {
            sb.Append(row);
        }
        return sb.ToString();
    }
}
// @lc code=end

