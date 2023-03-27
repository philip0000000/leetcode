public class Solution {
    public int OddCells(int m, int n, int[][] indices) {
        var matrix = new int[m, n];
        for (int i = 0; i < indices.Length; i++)
        {
            int y = indices[i][0],
                x = indices[i][1];
            for (int j = 0; j < n; j++)
                matrix[y, j]++;
            for (int l = 0; l < m; l++)
                matrix[l, x]++;
        }
        int ret = 0;
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                if (matrix[i, j] % 2 != 0)
                    ret++;
        return ret;
    }
}
