// O(n log n) ???
public class Solution {
    int NumberOfBits(int i)
    {
        int num = 0;
        while (i > 0)
        {
            if ((i & 1) == 1)
                num++;
            i >>= 1;
        }
        return num;
    }

    public int[] CountBits(int n) {
        n++;
        int[] ans = new int[n];

        for (int i = 0; i < n; i++)
            ans[i] = NumberOfBits(i);

        return ans;
    }
}
