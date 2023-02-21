public class Solution {
    public bool FindSubarrays(int[] nums) {
        var hash = new HashSet<int>();
        for (int i = 1; i < nums.Length; i++)
            if (hash.Contains(nums[i]+nums[i-1]))
                return true;
            else
                hash.Add(nums[i]+nums[i-1]);
        return false;
    }
}
