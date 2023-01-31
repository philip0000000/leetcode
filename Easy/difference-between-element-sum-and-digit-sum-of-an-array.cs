public class Solution {
    public int DifferenceOfSum(int[] nums) {
        int esum = 0;
        int dsum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            esum += nums[i];
            while (nums[i] > 9)
            {
                dsum += nums[i] % 10;
                nums[i] /= 10;
            }
            dsum += nums[i];
        }
        return Math.Abs(esum-dsum);
    }
}
