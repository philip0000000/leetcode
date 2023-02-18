// 1st
public class Solution {
    public bool CanBeIncreasing(int[] nums) {
        bool rem = false;
        for (int i = 1; i < nums.Length; i++)
            if (nums[i-1] >= nums[i])
            {
                if (rem == true)
                    return false;
                rem = true;
                if (i > 1)
                {
                    int t = nums[i];
                    int l = nums[i-1];
                    int b = nums[i-2];
                    if (t > b && t < l)
                        nums[i] = t;
                    else
                        nums[i] = l;
                }
                else
                    nums[1] = Math.Min(nums[0], nums[1]);
            }
        return true;
    }
}

// 2nd https://leetcode.com/problems/remove-one-element-to-make-the-array-strictly-increasing/submissions/900556387/
public class Solution {
    public bool CanBeIncreasing(int[] nums) {
        bool rem = false;
        for (int i = 1; i < nums.Length; i++)
            if (nums[i-1] >= nums[i])
            {
                if (rem == true)
                    return false;
                rem = true;
                if (i > 1)
                {
                    if (!(nums[i] > nums[i-2] && nums[i] < nums[i-1]))
                        nums[i] = nums[i-1];
                }
                else if (nums[0] < nums[1])
                    nums[1] = nums[0];
            }
        return true;
    }
}

// 3rd 50~
public class Solution {
    public bool CanBeIncreasing(int[] nums) {
        bool rem = false;
        for (int i = 1; i < nums.Length; i++)
            if (nums[i-1] >= nums[i])
            {
                if (rem == true)
                    return false;
                rem = true;
                if (i > 1)
                {
                    if (nums[i-2] >= nums[i])
                        nums[i] = nums[i-1];
                }
                else if (nums[0] < nums[1])
                    nums[1] = nums[0];
            }
        return true;
    }
}
