public class Solution {
    public int SurfaceArea(int[][] grid) {
        int ret = 0;
        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid.Length; j++)
            {
                if (grid[i][j] == 0)
                    continue;
                ret += grid[i][j] * 4 + 2;
                if (i - 1 >= 0)
                    ret -= Math.Min(grid[i][j], grid[i - 1][j]);
                if (j - 1 >= 0)
                    ret -= Math.Min(grid[i][j], grid[i][j - 1]);
                if (i + 1 < grid.Length)
                    ret -= Math.Min(grid[i][j], grid[i + 1][j]);
                if (j + 1 < grid.Length)
                    ret -= Math.Min(grid[i][j], grid[i][j + 1]);
            }
        return ret;
    }
}
