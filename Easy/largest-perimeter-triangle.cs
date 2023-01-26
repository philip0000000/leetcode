public class Solution {
    public int LargestPerimeter(int[] nums) {
        Array.Sort(nums);
        int n = nums.Length - 1;
        while (n >= 2 && nums[n] >= nums[n - 1] + nums[n - 2])
            n--;
        return n >= 2 ? nums[n] + nums[n - 1] + nums[n - 2] : 0;
    }
}
