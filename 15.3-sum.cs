/*
 * @lc app=leetcode id=15 lang=csharp
 *
 * [15] 3Sum
 */

// @lc code=start
using System.Collections.Generic;
public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        if (nums.Length < 3)
        {
            return result;
        }

        System.Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i == 0 || nums[i] != nums[i - 1])
            {
                int target = 0 - nums[i];
                int low = i + 1;
                int high = nums.Length - 1;
                while (low < high)
                {
                    int sum = nums[low] + nums[high];
                    if (sum == target)
                    {
                        result.Add(new List<int>() {
                            nums[i],
                            nums[low],
                            nums[high]
                        });
                        while (low < high && nums[low] == nums[low + 1]) low++;
                        while (low < high && nums[high] == nums[high - 1]) high--;
                        low++;
                        high--;
                    }
                    else if (sum > target) high--;
                    else low++;
                }
            }
        }
        return result;
    }
}
// @lc code=end

