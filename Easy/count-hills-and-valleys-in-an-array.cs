// https://leetcode.com/problems/count-hills-and-valleys-in-an-array/submissions/904142681/
public class Solution {
    public int CountHillValley(int[] nums) {
        int i = 0;
        for (int j = 1; j < nums.Length; j++)
            if (nums[i] != nums[j])
                nums[++i] = nums[j];
        int ret = 0;
        for (int j = 1; j < i; j++)
            if ((nums[j-1]>nums[j] && nums[j+1]>nums[j]) ||
                (nums[j-1]<nums[j] && nums[j+1]<nums[j]))
                ret++;
        return ret;
    }
}
