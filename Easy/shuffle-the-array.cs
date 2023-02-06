public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        var arr = new int[nums.Length];
        int p = 0;
        int p2 = n;
        int i = 0;
        while (p < n)
        {
            arr[i] = nums[p];
            p++;
            i++;
            arr[i] = nums[p2];
            p2++;
            i++;
        }
        return arr;
    }
}
