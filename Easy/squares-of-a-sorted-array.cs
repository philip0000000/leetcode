public class Solution {
    public int[] SortedSquares(int[] nums) {
        if (nums.Length==1)
            return new int[] { nums[0] * nums[0] };
        int l = 0, r = nums.Length;
        while (l <= r)
        {
            int m = (l+r)/2;
            if (m >= nums.Length)
                break;
            if (nums[m] >= 0)
                r = m-1;
            else
                l = m+1;
        }
        int i = l - 1;
        int[] ret = new int[nums.Length];
        int j = 0;
        while (l < nums.Length && nums[l]==0)
        {
            j++;
            l++;
        }
        while (l<nums.Length && i >= 0)
        {
            if (nums[l]<-nums[i])
            {
                ret[j] = nums[l]*nums[l];
                l++;
            }
            else
            {
                ret[j] = nums[i]*nums[i];
                i--;
            }
            j++;
        }
        while (l<nums.Length)
        {
            ret[j] = nums[l]*nums[l];
            l++;
            j++;
        }
        while (i>=0)
        {
            ret[j] = nums[i]*nums[i];
            i--;
            j++;
        }
        return ret;
    }
}
