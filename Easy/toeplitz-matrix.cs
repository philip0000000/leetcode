public class Solution {
    public bool IsToeplitzMatrix(int[][] matrix) {
        var list = new List<int>();
        for (int i = 0; i < matrix[0].Length; i++)
            list.Add(matrix[0][i]);
        for (int i = 1; i < matrix.Length; i++)
        {
            list.Insert(0, matrix[i][0]);
            for (int j = 1; j < matrix[i].Length; j++)
                if (list[j]!=matrix[i][j])
                    return false;
        }
        return true;
    }
}
