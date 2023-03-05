// 1st
public class Solution {
    public int[] LeftRigthDifference(int[] nums) {
        var answer = new int[nums.Length];
        int rightSum = 0;
        for (int i = nums.Length - 1; i > 0; i--)
            rightSum += nums[i];
        answer[0] = rightSum;
        int leftSum = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            rightSum -= nums[i];
            answer[i] = Math.Abs(leftSum - rightSum);
            leftSum += nums[i];
        }
        return answer;
    }
}

// 2nd 50%~
public class Solution {
    public int[] LeftRigthDifference(int[] nums) {
        int rightSum = 0, leftSum = 0;
        foreach (int n in nums)
            rightSum += n;
        for (int i = 0; i < nums.Length; i++)
        {
            rightSum -= nums[i];
            int temp = nums[i];
            nums[i] = Math.Abs(leftSum - rightSum);
            leftSum += temp;
        }
        return nums;
    }
}
