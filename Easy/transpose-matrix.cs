// https://leetcode.com/problems/transpose-matrix/submissions/901636466/
public class Solution {
    public int[][] Transpose(int[][] matrix) {
        int[][] ret = new int[matrix[0].Length][];
        for (int i = 0; i<ret.Length; i++)
            ret[i] = new int[matrix.Length];
        for (int y = 0, x1 = 0; y < matrix.Length; y++, x1++)
            for (int x = 0, y1 = 0; x < matrix[y].Length; x++, y1++)
                ret[y1][x1] = matrix[y][x];
        return ret;
    }
}
