// 1st
public class Solution {
    public IList<int> Intersection(int[][] nums) {
        var hash = new HashSet<int>();
        for (int i = 0; i < nums[0].Length; i++)
            hash.Add(nums[0][i]);
        for (int m = 1; m < nums.Length; m++)
        {
            var tempHash = new HashSet<int>();
            for (int i = 0; i < nums[m].Length; i++)
                if (hash.Contains(nums[m][i]))
                    tempHash.Add(nums[m][i]);
            hash = tempHash;
        }
        var list = hash.ToList();
        list.Sort();
        return list;
    }
}

// 2nd https://leetcode.com/problems/intersection-of-multiple-arrays/submissions/921603428/
public class Solution {
    public IList<int> Intersection(int[][] nums) {
        var dict = new Dictionary<int, int>();
        for (int m = 0; m < nums.Length; m++)
        {
            for (int i = 0; i < nums[m].Length; i++)
                if (dict.ContainsKey(nums[m][i]))
                    dict[nums[m][i]]++;
                else
                    dict.Add(nums[m][i], 1);
        }
        var list = new List<int>();
        foreach (var kvp in dict)
            if (kvp.Value == nums.Length)
                list.Add(kvp.Key);
        list.Sort();
        return list;
    }
}
