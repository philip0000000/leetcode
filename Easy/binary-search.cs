public class Solution {
    public int BinarySearch(int[] nums, int l, int r, int target)
    {
        if (l > r) return -1;
        int m = l + (r-l)/2;
        return (nums[m] == target) ? m :
               (nums[m] < target)  ? BinarySearch(nums, m + 1, r, target) : BinarySearch(nums, l, m - 1, target);
    }
    public int Search(int[] nums, int target) {
        return BinarySearch(nums, 0, nums.Length - 1, target);
    }
}
