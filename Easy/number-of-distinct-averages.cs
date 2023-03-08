public class Solution {
    public int DistinctAverages(int[] nums) {
        var ret = new HashSet<float>();
        Array.Sort(nums);
        for (int i = 0, j = nums.Length-1; i < j; i++, j--)
            ret.Add(((float)(nums[i]+nums[j]))/2);
        return ret.Count;
    }
}
