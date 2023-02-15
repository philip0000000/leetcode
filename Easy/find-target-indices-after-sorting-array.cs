// https://leetcode.com/problems/find-target-indices-after-sorting-array/submissions/898409013/
public class Solution {
    public IList<int> TargetIndices(int[] nums, int target) {
        var ret = new List<int>();
        Array.Sort(nums);
        int l = 0, r = nums.Length - 1;
        while (l <= r)
        {
            int m = (l+r)/2;
            if (nums[m] >= target)
                r = m - 1;
            else
                l = m + 1;
        }
        if (l < nums.Length && nums[l] == target)
        {
            ret.Add(l);
            for (l++; l < nums.Length && nums[l] == target; l++)
                ret.Add(l);
        }
        return ret.ToArray();
    }
}
