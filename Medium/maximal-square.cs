public class Solution {
    public int MaximalSquare(char[][] matrix) {
        int ret = 0;
        for (int y = 0; y < matrix.Length; y++)
            for (int x = 0; x < matrix[y].Length; x++)
                if (matrix[y][x] == '1')
                {
                    int u  = y - 1 >= 0 ? matrix[y-1][x] - '0' : 0;
                    int l  = x - 1 >= 0 ? matrix[y][x-1] - '0' : 0;
                    int ul = y - 1 >= 0 && x - 1 >= 0 ? matrix[y-1][x-1] - '0' : 0;
                    if (u > 0 && l > 0 && ul > 0)
                    {
                        int m = Math.Min(u, Math.Min(l, ul)) + 1;
                        matrix[y][x] = (char)(m + '0');
                        if (m > ret)
                            ret = m;
                    }
                    else if (ret == 0)
                        ret = 1;
                }
        return ret*ret;
    }
}
