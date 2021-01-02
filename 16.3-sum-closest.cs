/*
 * @lc app=leetcode id=16 lang=csharp
 *
 * [16] 3Sum Closest
 */

// @lc code=start
public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        if (nums.Length == 3)
        {
            return nums.Sum();
        }

        System.Array.Sort(nums);
        int minDistance = int.MaxValue;
        int closestSum = target;
        for (int nth = 0; nth < nums.Length; nth++)
        {
            int left = nth + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[nth] + nums[left] + nums[right];
                if (sum == target)
                {
                    return target;
                }
                else
                {
                    int distance = System.Math.Abs(target - sum);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestSum = sum;
                    }

                    if (sum < target)
                    {
                        while (left < right && nums[left] == nums[left + 1]) left++;
                        left++;
                    }
                    else
                    {
                        while (left < right && nums[right] == nums[right - 1]) right--;
                        right--;
                    }
                }
            }
        }
        return closestSum;
    }
}
// @lc code=end

