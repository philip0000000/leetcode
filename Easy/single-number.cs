public class Solution {
    public int SingleNumber(int[] nums) {
        int i = nums[0];
        for (int j = 1; j < nums.Length; j++)
            i = i ^ nums[j];
        return i;
    }
}
