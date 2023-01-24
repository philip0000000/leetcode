public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int []arr0 = new int[nums.Length+2];
        int []arr1 = new int[nums.Length+2];
        arr0[0] = 1;
        arr1[arr0.Length-1] = 1;
        int m = arr0.Length - 1;
        for (int n = 1; n < m; n++)
            arr0[n] = arr0[n-1] * nums[n-1];
        for (int n = arr1.Length - 2; n > 1; n--)
            arr1[n] = arr1[n + 1] * nums[n-1];
        for (int n = 1; n < m; n++)
            nums[n-1] = arr0[n-1] * arr1[n+1];
        return nums;
    }
}
