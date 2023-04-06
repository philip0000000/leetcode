public class Solution {
    public void SetZeroes(int[][] matrix) {
        bool Down = false;
        bool Right = false;
        for (int y = 0; y < matrix.Length; y++)
            for (int x = 0; x < matrix[0].Length; x++)
                if (matrix[y][x] == 0)
                {
                    if (y == 0)
                        Down = true;
                    if (x == 0)
                        Right = true;
                    matrix[0][x] = 0;
                    matrix[y][0] = 0;
                }
        for (int i = matrix.Length-1; i > 0; i--)
            if (matrix[i][0] == 0)
                for (int j = 0; j < matrix[0].Length; j++)
                    matrix[i][j] = 0;
        for (int i = matrix[0].Length-1; i > 0; i--)
            if (matrix[0][i] == 0)
                for (int j = 0; j < matrix.Length; j++)
                    matrix[j][i] = 0;
        if (Down)
            for (int j = 0; j < matrix[0].Length; j++)
                matrix[0][j] = 0;
        if (Right)
            for (int j = 0; j < matrix.Length; j++)
                matrix[j][0] = 0;
    }
}
