public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) {
        int i = 0;
        int lastNum = -1;
        while (i < nums1.Length)
        {
            while (i < nums1.Length && nums1[i] == lastNum)
                i++;
            lastNum = nums1[i];
            int l = 0, r = nums2.Length;
            while (l <= r)
            {
                int m = (l+r)/2;
                if (m >= nums2.Length)
                    break;
                if (nums2[m] == lastNum)
                    return lastNum;
                if (nums2[m] > lastNum)
                    r = m - 1;
                else
                    l = m + 1;
            }
            i++;
        }
        return -1;
    }
}
