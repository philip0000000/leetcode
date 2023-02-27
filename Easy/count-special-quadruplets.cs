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

// 80%~
public class Solution {
    public int CountQuadruplets(int[] nums) {
        int count=0;
        for(int i=0;i<nums.Length-2;i++)
        {
            for(int j=i+1;j<nums.Length-1;j++)
            {
                for(int k=j+1;k<nums.Length;k++)
                {
                    for(int d=k+1;d<nums.Length;d++)
                        if(nums[i]+nums[j]+nums[k]==nums[d])
                            count++;
                }
            }
        }
        return count;
    }
}
