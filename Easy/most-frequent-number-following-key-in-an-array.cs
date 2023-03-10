public class Solution {
    public int MostFrequent(int[] nums, int key) {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length - 1; i++)
            if (nums[i] == key)
            {
                if (dict.ContainsKey(nums[i+1]))
                    dict[nums[i+1]]++;
                else
                    dict.Add(nums[i+1], 1);
            }
        int ret = 0;
        int max = 0;
        foreach (var kvp in dict)
            if (kvp.Value > max)
            {
                max = kvp.Value;
                ret = kvp.Key;
            }
        return ret;
    }
}
