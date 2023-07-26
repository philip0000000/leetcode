public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        var ret = new int[nums.Length];
        var dict = new Dictionary<int, int>();

        foreach (var i in nums)
            if (dict.ContainsKey(i))
                dict[i]++;
            else
                dict.Add(i, 1);

        for (var i = 0; i < nums.Length; i++)
        {
            int sum = 0;
            foreach (var kvp in dict)
                if (kvp.Key < nums[i])
                    sum += kvp.Value;
            ret[i] = sum;
        }

        return ret;
    }
}
