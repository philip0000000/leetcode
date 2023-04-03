public class Solution {
    public int LargestSumAfterKNegations(int[] nums, int k) {
        Array.Sort(nums);
        int i = 0;
        while (i < nums.Length && nums[i] < 0 && k > 0)
        {
            nums[i] = -nums[i];
            i++;
            k--;
        }
        if (k > 0)
        {
            if (i >= nums.Length)
                i--;
            if (i > 0 && nums[i-1] < nums[i])
                i--;
            k %= 2;
            while (k > 0)
            {
                nums[i] = -nums[i];
                k--;
            }
        }
        int ret = 0;
        foreach (var n in nums)
            ret += n;
        return ret;
    }
}
