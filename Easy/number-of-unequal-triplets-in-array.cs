public class Solution {
    public int UnequalTriplets(int[] nums) {
        int ret = 0;
        for (int i = 2; i < nums.Length; i++)
            for (int j = 0; j < i-1; j++)
                for (int k = j+1; k < i; k++)
                    if (nums[i] != nums[j] && nums[i] != nums[k] && nums[j] != nums[k])
                        ret++;
        return ret;
    }
}
