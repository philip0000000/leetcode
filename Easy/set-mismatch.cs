public class Solution {
    public int[] FindErrorNums(int[] nums) {
        Array.Sort(nums);
        int d = 0;
        for (int i = nums.Length-2; i>=0; i--)
            if (nums[i]==nums[i+1])
            {
                d = nums[i];
                break;
            }
        int c = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i]==d)
                i++;
            if (c!=nums[i])
                return new int[] { d, c };
            c++;
        }
        return new int[] { d, c };
    }
}
