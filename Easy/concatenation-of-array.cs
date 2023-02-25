public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var ret = new int[nums.Length*2];
        for (int i = 0, j = nums.Length; i < nums.Length; i++, j++)
        {
            ret[i] = nums[i];
            ret[j] = nums[i];
        }
        return ret;
    }
}
