public class Solution {
    public int SumOfUnique(int[] nums) {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
            if (dict.ContainsKey(nums[i]))
                dict[nums[i]]++;
            else
                dict.Add(nums[i], 1);
        int ret = 0;
        foreach (KeyValuePair<int, int> kvp in dict)
            if (kvp.Value==1)
                ret+=kvp.Key;
        return ret;
    }
}
