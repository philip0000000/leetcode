public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        var ret = new List<string>();
        int p0 = 0;
        int p1 = 0;
        while (p0 < nums.Length)
        {
            while (p1+1 < nums.Length && nums[p1+1] == nums[p1]+1)
                p1++;
            if (p0 == p1)
                ret.Add($"{nums[p0]}");
            else
                ret.Add($"{nums[p0]}->{nums[p1]}");
            p1++;
            p0 = p1;
        }
        return ret;
    }
}
