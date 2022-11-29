// 1st
public class Solution {

    public int[] RunningSum(int[] nums) {

        if (nums.Length > 1)

            for (int n = 1; n < nums.Length; n++)

            {

                nums[n] += nums[n-1];

            }

        return nums;

    }

}

// 2nd
public class Solution {
    public int[] RunningSum(int[] nums) {
        var arr = new int[nums.Length];
        arr[0] = nums[0];
        if (nums.Length > 1)
        {
            for (int n = 1; n < nums.Length; n++)
            {
                arr[n] = nums[n] + arr[n-1];
            }
        }
        return arr;
    }
}
