public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(target - nums[i]))
                return new[] { i, dict[target - nums[i]] };
            if (dict.ContainsKey(nums[i]) == false)
                dict.Add(nums[i], i);
        }
        return new int[0];
    }
}
