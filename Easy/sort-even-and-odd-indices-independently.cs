// https://leetcode.com/problems/sort-even-and-odd-indices-independently/submissions/904894552/
public class Solution {
    public int[] SortEvenOdd(int[] nums) {
        var eve = new int[nums.Length];
        var odd = new int[nums.Length];
        for (int m = 0, i = 0; i < nums.Length; m++, i += 2)
            eve[m] = nums[i];
        for (int m = 0, i = 1; i < nums.Length; m++, i += 2)
            odd[m] = nums[i];
        Array.Sort(eve);
        Array.Sort(odd);
        for (int m = nums.Length/2, i = 0; i < nums.Length; m++, i += 2)
            nums[i] = eve[m];
        for (int m = nums.Length-1, i = 1; i < nums.Length; m--, i += 2)
            nums[i] = odd[m];
        return nums;
    }
}
