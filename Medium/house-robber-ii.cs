// 50%~
public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 1)
            return nums[0];
        else if (nums.Length == 2)
            return Math.Max(nums[0], nums[1]);
        else if (nums.Length == 3)
            return Math.Max(nums[0], Math.Max(nums[1], nums[2]));
        else if (nums.Length == 4)
            return Math.Max(nums[0]+nums[2], nums[1]+nums[3]);

        int[] nums2 = new int[nums.Length];
        nums.CopyTo(nums2, 0);

        nums[nums.Length - 3] += nums[nums.Length - 1];
        for (int n = nums.Length - 4; n > 0; n--)
            nums[n] += Math.Max(nums[n + 2], nums[n + 3]);
        int n1 = Math.Max(nums[1], nums[2]);

        nums2[nums.Length - 4] += nums2[nums.Length - 2];
        for (int n = nums2.Length - 5; n >= 0; n--)
            nums2[n] += Math.Max(nums2[n + 2], nums2[n + 3]);
        int n2 = Math.Max(nums2[0], nums2[1]);

        return Math.Max(n1, n2);
    }
}
