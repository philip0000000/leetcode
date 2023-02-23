public class Solution {
    public int[] FindErrorNums(int[] nums) {
        Array.Sort(nums);
        int d = 0;
        for (int i = nums.Length-2; i>=0; i--)
            if (nums[i]==nums[i+1])
            {
                d = nums[i];
                break;
            }
        int c = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i]==d)
                i++;
            if (c!=nums[i])
                return new int[] { d, c };
            c++;
        }
        return new int[] { d, c };
    }
}

// 2nd 50%~
public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int d = -1;
        var hash = new HashSet<int>();
        int l = nums.Length * (nums.Length + 1) / 2;
        foreach (int n in nums)
            if (hash.Contains(n))
                d = n;
            else
            {
                l -= n;
                hash.Add(n);
            }
        return new int[] { d, l };
    }
}
