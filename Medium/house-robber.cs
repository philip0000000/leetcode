public class Solution {
    public int Rob(int[] nums)
    {
        if (nums.Length == 1)
            return nums[0];
        if (nums.Length > 2)
            nums[nums.Length - 3] += nums[nums.Length - 1];
        for (int n = nums.Length - 4; n >= 0; n--)
            nums[n] += Math.Max(nums[n + 2], nums[n + 3]);
        return Math.Max(nums[0], nums[1]);
    }
}
