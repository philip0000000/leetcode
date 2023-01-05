public class Solution {
    public int ArrayPairSum(int[] nums) {
        Array.Sort(nums);
        int ret = 0;
        for (int i = 0, l = nums.Length; i < l; i+=2)
            ret += nums[i];
        return ret;
    }
}
