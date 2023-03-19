public class Solution {
    public int MinOperations(int[] nums) {
        int ret = 0;
        for (int i = 0, max = 0; i < nums.Length; i++)
            if (nums[i] > max)
                max = nums[i];
            else
            {
                max++;
                ret += max - nums[i];
            }
        return ret;
    }
}
