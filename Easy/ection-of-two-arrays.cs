// 1st
public int[] Intersection(int[] nums1, int[] nums2) {
    HashSet<int> seen = new HashSet<int>();
    foreach (int x in nums1)
    {
        if (seen.Contains(x) == false)
            seen.Add(x);
    }
    HashSet<int> ret = new HashSet<int>();
    foreach (int x in nums2)
    {
        if (seen.Contains(x) == true)
            if (ret.Contains(x) == false)
                ret.Add(x);
    }
    return ret.ToArray();
}

// 2nd...
HashSet<int> set = new HashSet<int>(nums1);
set.IntersectWith(nums2);
return set.ToArray();
