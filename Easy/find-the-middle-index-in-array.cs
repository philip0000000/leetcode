public class Solution {
    public int FindMiddleIndex(int[] nums) {
        int l = 0;
        int r = 0;
        int n = nums.Length-1;
        while (n > 0)
        {
            r += nums[n];
            n--;
        }
        do {
            if (l==r)
                return n;
            l+=nums[n];
            n++;
            if (n<nums.Length)
                r-=nums[n];
        } while (n<nums.Length);
        return -1;
    }
}
