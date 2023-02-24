public class Solution {
    public int[][] MergeArrays(int[][] nums1, int[][] nums2) {
        var list = new List<int[]>();
        int i = 0, j = 0;
        for (; i < nums1.Length && j < nums2.Length;)
            if (nums1[i][0]==nums2[j][0])
            {
                list.Add(new int[] { nums1[i][0], nums1[i][1]+nums2[j][1] });
                i++;
                j++;
            }
            else if (nums1[i][0]<nums2[j][0])
            {
                list.Add(new int[] { nums1[i][0], nums1[i][1] });
                i++;
            }
            else
            {
                list.Add(new int[] { nums2[j][0], nums2[j][1] });
                j++;
            }
        for (;i < nums1.Length; i++)
            list.Add(new int[] { nums1[i][0], nums1[i][1] });
        for (;j < nums2.Length; j++)
            list.Add(new int[] { nums2[j][0], nums2[j][1] });
        return list.ToArray();
    }
}
