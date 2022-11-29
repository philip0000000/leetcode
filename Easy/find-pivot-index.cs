// 1st
public class Solution {
    public int PivotIndex(int[] nums) {
        if (nums.Length > 1)
        {
            int n = 0;
            while (n < nums.Length)
            {
                int LSum = 0, RSum = 0;
                // get left sum
                for (int m = 0; m < n; m++)
                    LSum += nums[m];
                // get right sum
                for (int m = nums.Length - 1; m > n; m--)
                    RSum += nums[m];
                if (LSum == RSum) // is this the Pivot Index?
                    return n; // yes, it is the Pivot Index
                n++; // no, try again
            }
        }
        else
            return 0;
        return -1;
    }
}

// 2nd
public class Solution {
    public int PivotIndex(int[] nums) {
        int RSum = 0, LSum = 0;
        for (int m = 0; m < nums.Length; m++)
            RSum += nums[m];
        int n = 0;
        do {
            RSum -= nums[n];
            if (LSum == RSum) return n; // test Pivot Index
            LSum += nums[n];
            n++;
        } while (n < nums.Length);
        return -1;
    }
}
