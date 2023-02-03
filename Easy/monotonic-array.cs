public class Solution {
    public bool IsMonotonic(int[] nums) {
        int i = 0;
        for (; i < nums.Length-1; i++)
            if (nums[i] > nums[i+1])
                break;
        if (i == nums.Length-1)
            return true;
        for (i = nums.Length-2; i >= 0; i--)
            if (nums[i] < nums[i+1])
                return false;
        return true;
    }
}
