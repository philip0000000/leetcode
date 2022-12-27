// 1st
public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        var NumbersFound = new HashSet<int>();
        foreach (var n in nums)
            if (!NumbersFound.Contains(n))
                NumbersFound.Add(n);
        var ret = new List<int>();
        for (int i = 1; i < nums.Length + 1; i++)
            if (!NumbersFound.Contains(i))
                ret.Add(i);
        return ret;
    }
}

// 2nd 50%~
public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        bool[] found = new bool[nums.Length + 1];
        for (int i = 0; i < nums.Length; i++)
            found[nums[i]] = true;
        var ret = new List<int>();
        for (int i = 1; i < found.Length; i++)
            if (!found[i])
                ret.Add(i);
        return ret;
    }
}
