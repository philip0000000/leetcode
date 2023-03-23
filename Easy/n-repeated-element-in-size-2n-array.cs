public class Solution {
    public int RepeatedNTimes(int[] nums) {
        var hash = new HashSet<int>();
        foreach (var i in nums)
            if (hash.Contains(i))
                return i;
            else
                hash.Add(i);
        return 0;
    }
}
