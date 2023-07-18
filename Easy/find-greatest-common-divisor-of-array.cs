// 1st
public class Solution {
    static public int GCD(int a, int b)
    {
        int ret = a % b;
        if (ret == 0)
            return b;
        return GCD(b, ret);
    }
    public int FindGCD(int[] nums) {
        int min = 1001, max = -1;
        foreach (int n in nums)
        {
            min = Math.Min(min, n);
            max = Math.Max(max, n);
        }
        return GCD(max, min);
    }
}

// 2nd 50%~
public class Solution {
    static public int GCD(int a, int b)
    {
        int ret = a % b;
        if (ret == 0)
            return b;
        return GCD(b, ret);
    }
    public int FindGCD(int[] nums) {
        int min = nums.Min(),
            max = nums.Max();
        return GCD(max, min);
    }
}
