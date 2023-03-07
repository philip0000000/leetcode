public class Solution {
    public int[][] Construct2DArray(int[] original, int m, int n) {
        if (original.Length != m * n)
            return new int[0][];
        var ret = new int[m][];
        int j = 0;
        for (int i = 0; i < m; i++)
        {
            ret[i] = new int[n];
            for (int k = 0; k < n; k++, j++)
                ret[i][k] = original[j];
        }
        return ret;
    }
}
