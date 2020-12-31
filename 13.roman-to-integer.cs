/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */

// @lc code=start
public class Solution
{
    public int RomanToInt(string s)
    {
        System.Collections.Generic.Dictionary<string, int> set1 =
            new System.Collections.Generic.Dictionary<string, int>
            {
                {"M", 1000},
                {"D", 500},
                {"C", 100},
                {"L", 50},
                {"X", 10},
                {"V", 5},
                {"I", 1},
            };
        System.Collections.Generic.Dictionary<string, int> set2 =
            new System.Collections.Generic.Dictionary<string, int>
            {
                {"CM", 900},
                {"CD", 400},
                {"XC", 90},
                {"XL", 40},
                {"IX", 9},
                {"IV", 4},
            };

        int result = 0;
        int i = 0;
        while (i < s.Length)
        {
            if (i < s.Length - 1 && set2.ContainsKey(s.Substring(i, 2)))
            {
                result += set2[s.Substring(i, 2)];
                i += 2;
            }
            else
            {
                result += set1[s.Substring(i, 1)];
                i += 1;
            }
        }
        return result;
    }
}
// @lc code=end

