public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        var ret = new int[nums.Length];
        int p0 = 0, p1 = nums.Length - 1;
        foreach (var i in nums)
            if ((i % 2) == 0)
            {
                ret[p0] = i;
                p0++;
            }
            else
            {
                ret[p1] = i;
                p1--;
            }
        return ret;
    }
}
