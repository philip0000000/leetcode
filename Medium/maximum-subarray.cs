// https://leetcode.com/problems/maximum-subarray/submissions/869538429/
public class Solution {
    public int MaxSubArray(int[] nums) {
        int MaxValue = nums[0];
        for (int PreVal = nums[0], n = 1; n < nums.Length; n++)
        {
            PreVal += nums[n];
            if (nums[n] > PreVal)
                PreVal = nums[n];
            if (PreVal > MaxValue)
                MaxValue = PreVal;
        }
        return MaxValue;
    }
}
