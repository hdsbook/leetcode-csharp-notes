public class Solution {
    public int MaxSubArray(int[] nums) {
        var sum = 0;
        var maxSum = nums[0];
        foreach (var num in nums)
        {
            if (sum < 0)
            {
                sum = num > 0 ? num : Math.Max(sum, num);
            }
            else
            {
                sum += num;
            }
            maxSum = Math.Max(sum, maxSum);
        }
        return maxSum;
    }
}

// [TestCase(new int[]{-2,1,-3,4,-1,2,1,-5,4}, 6)]
// [TestCase(new int[]{5,4,-1,7,8}, 23)]
// [TestCase(new int[]{1}, 1)]
// [TestCase(new int[]{-2, -1}, -1)]
// public void METHOD(int[] nums, int expected)
// {
//     var sum = 0;
//     var maxSum = nums[0];
//     foreach (var num in nums)
//     {
//         if (sum < 0)
//         {
//             sum = num > 0 ? num : Math.Max(sum, num);
//         }
//         else
//         {
//             sum += num;
//         }
//         maxSum = Math.Max(sum, maxSum);
//     }
//     Assert.AreEqual(expected, maxSum);
// }