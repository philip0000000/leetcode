// 1st https://leetcode.com/problems/move-zeroes/submissions/868413824/
public class Solution {
    public void MoveZeroes(int[] nums) {
        int i = 0;
        while (i < nums.Length)
        {
            if (nums[i] == 0)
            {
                int n = i + 1;
                while (n < nums.Length && nums[n] == 0)
                    n++;
                if (n < nums.Length && nums[n] != 0)
                {
                    nums[i] = nums[n];
                    nums[n] = 0;
                }
            }
            i++;
        }
    }
}

// 2nd https://leetcode.com/problems/move-zeroes/submissions/868416920/
public class Solution {
    public void MoveZeroes(int[] nums) {
        int n = 0, i = 0;
        while (i < nums.Length)
        {
            if (nums[i] != 0)
                nums[n++] = nums[i];
            i++;
        }
        while (n < nums.Length)
            nums[n++] = 0;
    }
}
