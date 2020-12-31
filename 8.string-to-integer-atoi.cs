/*
 * @lc app=leetcode id=8 lang=csharp
 *
 * [8] String to Integer (atoi)
 */

// @lc code=start
using System;
public class Solution
{
    public int MyAtoi(string s)
    {
        s = s.Trim();
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }

        bool isNegative = (s[0] == '-');
        if (s[0] == '+' || s[0] == '-')
        {
            s = s.Substring(1);
        }

        int number = 0, digit = 0;
        foreach (char c in s)
        {
            if (!char.IsNumber(c))
            {
                break;
            }

            digit = (c - '0');
            if (number > (int.MaxValue - digit) / 10)
            {
                return isNegative ? int.MinValue : int.MaxValue;
            }

            number = number * 10 + digit;
        }

        return isNegative ? -number : number;
    }
}
// @lc code=end

