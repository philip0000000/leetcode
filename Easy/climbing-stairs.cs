//Fibonacci number
public class Solution {
    public int ClimbStairs(int n) {
        int n0 = 0;
        int n1 = 1;
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 1)
                n1 = n0 + n1;
            else
                n0 = n0 + n1;
        }

        return n0 > n1 ? n0 : n1;
    }
}

