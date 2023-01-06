public class Solution {
    public int UniquePaths(int m, int n) {
        var grid = new int[m,n];
        int tm = m - 1, tn = n - 1;
        for (int tm2 = m - 1; tm2 >= 0; tm2--)
            grid[tm2, tn] = 1;
        for (int tn2 = n - 1; tn2 >= 0; tn2--)
            grid[tm, tn2] = 1;
        for (tm--, tn--; tm >= 0; tm--)
            for (int t = tn; t >= 0; t--)
                grid[tm, t] = grid[tm, t+1] + grid[tm+1, t];
        return grid[0,0];
    }
}
