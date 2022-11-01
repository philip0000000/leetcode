public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int l = nums.Length;
        int find;
        int current = 0;
        int n = 1;
        
        do {
            find = target - nums[current];
            do {
                if (find == nums[n])
                    return new [] { current, n };
                n++;
            } while (n < l);
            current++;
            n = current + 1;
        } while (current < l);

        return null;
    }
}
