public class Solution {
    public int CountNegatives(int[][] grid) {
        int n = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            int l = 0, r = grid[i].Length;
            while (l <= r)
            {
                int m = (l + r) / 2;
                if (m >= grid[i].Length)
                    break;
                if (grid[i][m] >= 0)
                    l = m + 1;
                else
                    r = m - 1;
            }
            n += grid[i].Length - l;
        }
        return n;
    }
}
