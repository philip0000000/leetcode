// https://leetcode.com/problems/sign-of-the-product-of-an-array/submissions/882247287/
public class Solution {
    public int ArraySign(int[] nums) {
        int ret = 1;
        for (int n = 0; n < nums.Length; n++)
            if (nums[n] == 0)
                return 0;
            else if (nums[n] < 0)
                ret *= -1;
        return ret;
    }
}
