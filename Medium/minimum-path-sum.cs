public class Solution {
    public int MinPathSum(int[][] grid) {
        int y = 0;
        int x = 0;
        while (y < grid.Length)
        {
            x = 0;
            while (x < grid[y].Length)
            {
                int u = y-1 >= 0 ? grid[y-1][x] : -1;
                int l = x-1 >= 0 ? grid[y][x-1] : -1;
                if (u >= 0 && l >= 0)
                    grid[y][x] += u < l ? u : l;
                else if (u >= 0 && l == -1)
                    grid[y][x] += u;
                else if (u == -1 && l >= 0)
                    grid[y][x] += l;
                Console.WriteLine(grid[y][x]);
                x++;
            }
            y++;
        }
        return grid[y-1][x-1];
    }
}
