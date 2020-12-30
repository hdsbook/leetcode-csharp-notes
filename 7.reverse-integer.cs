/*
 * @lc app=leetcode id=7 lang=csharp
 *
 * [7] Reverse Integer
 */

// @lc code=start
using System;
public class Solution
{
    public int Reverse(int x)
    {
        if (x >= int.MaxValue || x <= int.MinValue)
        {
            return 0;
        }

        int reverseInt = 0;
        int sign = x < 0 ? -1 : 1;

        char[] chars = Math.Abs(x).ToString().ToCharArray();
        Array.Reverse(chars);
        bool success = Int32.TryParse(new string(chars), out reverseInt);
        return success ? reverseInt * sign : 0;
    }
}
// @lc code=end

