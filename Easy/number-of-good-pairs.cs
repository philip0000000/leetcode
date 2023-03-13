// 1st
public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int ret = 0;
        for (int i = 0; i < nums.Length-1; i++)
            for (int j = i+1; j < nums.Length; j++)
                if (nums[i] == nums[j])
                    ret++;
        return ret;
    }
}

// 2nd
public class Solution {
    public int fibonacci(int i)
    {
        if (i <= 0)
            return 0;
        return i-1 + fibonacci(i-1);
    }
    public int NumIdenticalPairs(int[] nums) {
        int ret = 0;
        var dict = new Dictionary<int, int>();
        foreach (var i in nums)
            if (dict.ContainsKey(i))
                dict[i]++;
            else
                dict.Add(i, 1);
        foreach (var kvp in dict)
            if (kvp.Value > 1)
                ret += fibonacci(kvp.Value);
        return ret;
    }
}
