public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int max = 0;
        int c = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i]==1)
            {
                c++;
                if (c>max)
                    max = c;
            }
            else
                c = 0;
        }
        return max;
    }
}
