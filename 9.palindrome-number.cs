/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0 || (x % 10 == 0 && x != 0))
        {
            return false;
        }
        else if (x < 10)
        {
            return true;
        }

        int num = x;
        int reverseX = 0;
        while (num > 0)
        {
            reverseX = reverseX * 10 + (num % 10);
            num /= 10;
        }
        return x == reverseX;
    }
}
public class Solution2
{
    public bool IsPalindrome(int x)
    {
        if (x < 0 || (x % 10 == 0 && x != 0))
        {
            return false;
        }
        else if (x < 10)
        {
            return true;
        }

        int divisor = 1;
        int num = x;
        while (num > 9)
        {
            num /= 10;
            divisor *= 10;
        }

        num = x;
        int reverseX = 0;
        while (num > 0)
        {
            if (num % 10 != ((x / divisor) % 10))
            {
                return false;
            }
            divisor /= 10;
            num /= 10;
        }
        return true;
    }
}
// @lc code=end

