// 1st recursion
public class Solution {
    public int BinarySearch(int[] nums, int l, int r, int target)
    {
        if (l > r) return -1;
        int m = (l+r)/2;
        return (nums[m] == target) ? m :
               (nums[m] < target)  ? BinarySearch(nums, m + 1, r, target) : BinarySearch(nums, l, m - 1, target);
    }
    public int Search(int[] nums, int target) {
        return BinarySearch(nums, 0, nums.Length - 1, target);
    }
}

// 2nd imperative
public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0, r = nums.Length, max = nums.Length;
        while (l <= r)
        {
            int m = (l+r)/2;
            if (m >= max) return -1;
            if (nums[m] == target) return m;
            if (nums[m] < target) l = m + 1;
            else r = m - 1;
        }
        return -1;
    }
}
