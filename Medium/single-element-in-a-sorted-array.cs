// https://leetcode.com/problems/single-element-in-a-sorted-array/submissions/904204936/
public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        int l = 0, r = nums.Length;
        while (l < r)
        {
            int m = (l+r)/2;
            if (m==0)
            {
                return nums[0];
            }
            else if (m==nums.Length-1)
            {
                return nums[nums.Length-1];
            }
            else if ((m%2)==0)
            {
                if (nums[m] != nums[m + 1])
                    r = m;
                else
                    l = m + 1;
            }
            else
            {
                if (nums[m]!=nums[m+1])
                    l = m + 1;
                else
                    r = m - 1;
            }
        }
        return nums[l];
    }
}
