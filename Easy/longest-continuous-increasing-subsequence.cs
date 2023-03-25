public class Solution {
    public int FindLengthOfLCIS(int[] nums) {
        int ret = 1;
        int max = 0;
        for (int i = 0; i < nums.Length-1; i++)
            if (nums[i] < nums[i+1])
                ret++;
            else
            {
                if (ret > max)
                    max = ret;
                ret = 1;
            }
        return ret > max ? ret : max;
    }
}
