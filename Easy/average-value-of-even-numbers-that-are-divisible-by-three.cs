// 1st https://leetcode.com/problems/average-value-of-even-numbers-that-are-divisible-by-three/submissions/912755539/
public class Solution {
    public int AverageValue(int[] nums) {
        int sum = 0;
        int n = 0;
        foreach (int i in nums)
            if ((i%2)==0 && (i%3)==0)
            {
                sum += i;
                n++;
            }
        if (n == 0 && sum == 0)
            return 0;
        return sum / n;
    }
}

// 2nd 50%~
public class Solution {
    public int AverageValue(int[] nums) {
        int sum = 0;
        int n = 0;
        foreach (int i in nums)
            if ((i%6)==0)
            {
                sum += i;
                n++;
            }
        if (n == 0)
            return 0;
        return sum / n;
    }
}
