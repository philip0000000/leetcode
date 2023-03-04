public class Solution {
    public int MaxAscendingSum(int[] nums) {
        int ret = 0;
        int sum = nums[nums.Length-1];
        for (int i = nums.Length-2; i >= 0; i--)
            if (nums[i] < nums[i+1])
                sum += nums[i];
            else
            {
                if (sum > ret)
                    ret = sum;
                sum = nums[i];
            }
        if (sum > ret)
            return sum;
        return ret;
    }
}
