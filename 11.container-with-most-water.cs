/*
 * @lc app=leetcode id=11 lang=csharp
 *
 * [11] Container With Most Water
 */

// @lc code=start
public class Solution
{
    public int MaxArea(int[] height)
    {
        if (height.Length == 2)
        {
            return System.Math.Min(height[0], height[1]);
        }

        int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;
        while (right > left)
        {
            int width = right - left;
            int nowArea = width * System.Math.Min(height[left], height[right]);
            if (nowArea > maxArea)
            {
                maxArea = nowArea;
            }

            if (height[left] > height[right])
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        return maxArea;
    }
}
// @lc code=end

