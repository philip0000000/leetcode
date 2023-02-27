public class Solution {
    public int ArithmeticTriplets(int[] nums, int diff) {
        int ret = 0;
        for (int i = 0; i < nums.Length;)
        {
            for (int j = i+1; j < nums.Length; j++)
                if (nums[j]-nums[i] == diff)
                    for (int k = j+1; k < nums.Length; k++)
                        if (nums[k]-nums[j] == diff)
                        {
                            ret++;
                            goto endloop;
                        }
            endloop:
            i++;
        }
        return ret;
    }
}
