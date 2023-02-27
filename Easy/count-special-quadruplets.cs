public class Solution {
    public int CountQuadruplets(int[] nums) {
        int ret = 0;
        var dict = new Dictionary<int, int>();
        for (int p2 = 2, p3 = 3; p3 < nums.Length; p2++, p3++)
        {
            for (int p0 = 0; p0 < p2-1; p0++)
            {
                for (int p1 = p0 + 1; p1 < p2; p1++)
                {
                    int sum = nums[p0] + nums[p1] + nums[p2];
                    if (dict.ContainsKey(sum))
                        dict[sum]++;
                    else
                        dict.Add(sum, 1);
                }
            }
            if (dict.ContainsKey(nums[p3]))
                ret += dict[nums[p3]];
        }
        return ret;
    }
}
