// https://leetcode.com/problems/two-out-of-three/submissions/907424673/
public class Solution {
    public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3) {
        var hsAdd = new HashSet<int>();
        var hs0 = new HashSet<int>();
        for (int i = 0; i < nums1.Length; i++)
            if (!hs0.Contains(nums1[i]))
                hs0.Add(nums1[i]);
        var hs1 = new HashSet<int>();
        for (int i = 0; i < nums2.Length; i++)
        {
            if (!hs1.Contains(nums2[i]))
                hs1.Add(nums2[i]);
            if (hs0.Contains(nums2[i]))
                hsAdd.Add(nums2[i]);
        }
        for (int i = 0; i < nums3.Length; i++)
        {
            if (hs0.Contains(nums3[i]))
                hsAdd.Add(nums3[i]);
            if (hs1.Contains(nums3[i]))
                hsAdd.Add(nums3[i]);
        }
        return hsAdd.ToList();
    }
}
