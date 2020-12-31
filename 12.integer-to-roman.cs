/*
 * @lc app=leetcode id=12 lang=csharp
 *
 * [12] Integer to Roman
 */

// @lc code=start
public class Solution1
{
    public string IntToRoman(int num)
    {
        string[] I = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        string[] X = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] C = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] M = new string[] { "", "M", "MM", "MMM" };

        return M[num / 1000] + C[(num % 1000) / 100] + X[(num % 100) / 10] + I[num % 10];
    }
}
public class Solution
{
    public string IntToRoman(int num)
    {
        string[] I = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        string[] X = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] C = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] M = new string[] { "", "M", "MM", "MMM" };

        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        if (num >= 1000)
        {
            sb.Append(M[num / 1000]);
            num %= 1000;
        }
        if (num >= 100)
        {
            sb.Append(C[num / 100]);
            num %= 100;
        }
        if (num >= 10)
        {
            sb.Append(X[num / 10]);
            num %= 10;
        }
        sb.Append(I[num]);

        return sb.ToString();
    }
}
public class Solution2
{
    public string IntToRoman(int num)
    {
        string[] I = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        string[] X = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] C = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] M = new string[] { "", "M", "MM", "MMM" };

        if (num >= 1000)
        {
            return "M" + IntToRoman(num - 1000);
        }
        if (num >= 500)
        {
            return num >= 900
                ? "CM" + IntToRoman(num - 900)
                : "D" + IntToRoman(num - 500);
        }
        if (num >= 100)
        {
            return num >= 400
                ? "CD" + IntToRoman(num - 400)
                : "C" + IntToRoman(num - 100);

        }
        if (num >= 50)
        {
            return num >= 90
                ? "XC" + IntToRoman(num - 90)
                : "L" + IntToRoman(num - 50);
        }
        if (num >= 10)
        {
            return num >= 40
                ? "XL" + IntToRoman(num - 40)
                : "X" + IntToRoman(num - 10);
        }
        if (num >= 5)
        {
            return num >= 9
                ? "IX" + IntToRoman(num - 9)
                : "V" + IntToRoman(num - 5);
        }
        if (num >= 1)
        {
            return num >= 4
                ? "IV" + IntToRoman(num - 4)
                : "I" + IntToRoman(num - 1);
        }
        return "";
    }
}
public class MyOriginSolution
{
    public string IntToRoman(int num)
    {
        System.Collections.Generic.Dictionary<int, string> map =
            new System.Collections.Generic.Dictionary<int, string>
            {
                {1000, "M"},
                {900, "CM"},
                {500, "D"},
                {400, "CD"},
                {100, "C"},
                {90, "XC"},
                {50, "L"},
                {40, "XL"},
                {10, "X"},
                {9, "IX"},
                {5, "V"},
                {4, "IV"},
                {1, "I"},
            };

        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        while (num > 0)
        {
            if (map.ContainsKey(num))
            {
                sb.Append(map[num]);
                break;
            }

            foreach (var key in map.Keys.ToList())
            {
                if (num > key)
                {
                    do
                    {
                        num -= key;
                        sb.Append(map[key]);
                    } while (num > key);
                    break;
                }
                map.Remove(key);
            }
        }
        return sb.ToString();
    }
}
// @lc code=end

