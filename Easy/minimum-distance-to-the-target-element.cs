public class Solution {
    public int GetMinDistance(int[] nums, int target, int start) {
        int lowest = Int32.MaxValue;
        for (int i = 0; i < nums.Length; i++)
            if (nums[i] == target)
            {
                if (Math.Abs(i - start) < lowest)
                    lowest = Math.Abs(i - start);
            }
        return lowest;
    }
}
