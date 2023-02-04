// https://leetcode.com/problems/check-if-matrix-is-x-matrix/submissions/891581457/
public class Solution {
    public bool CheckXMatrix(int[][] grid) {
        for (int y = 0; y < grid.Length; y++)
            for (int x = 0; x < grid[y].Length; x++)
                if (y == x && grid[y][x] == 0)
                    return false;
                else if (y+x == grid[y].Length - 1 && grid[y][x] == 0)
                    return false;
                else if (y != x && y+x != grid[y].Length - 1 && grid[y][x] != 0)
                    return false;
        return true;
    }
}
