// https://leetcode.com/problems/merge-sorted-array/submissions/902299782/
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        if (m==0)
        {
            for (int i = 0; i < n; i++)
                nums1[i] = nums2[i];
        }
        else
        {
            int i = nums1.Length-1;
            m--;
            n--;
            while (i>=0 && m >= 0 && n >= 0)
            {
                if (nums1[m]>nums2[n])
                {
                    nums1[i]=nums1[m];
                    m--;
                }
                else
                {
                    nums1[i]=nums2[n];
                    n--;
                }
                i--;
            }
            while (n>=0)
            {
                nums1[i]=nums2[n];
                i--;
                n--;
            }
        }
    }
}
