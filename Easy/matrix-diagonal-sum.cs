public class Solution {
    public int DiagonalSum(int[][] mat) {
        int ret = 0;
        int l = mat.Length/2;
        if ((mat.Length%2)==1)
        {
            int v = (mat.Length/2);
            ret += mat[v][v];
        }
        int x0 = 0, x1 = mat.Length-1;
        int y0 = 0, y1 = mat.Length-1;
        while (y0 < l)
        {
            ret += mat[y0][x0] + mat[y0][x1]
                + mat[y1][x0] + mat[y1][x1];
            x0++;
            x1--;
            y0++;
            y1--;
        }
        return ret;
    }
}
