public class Solution {
    public bool CheckValid(int[][] matrix) {
        var nums = new HashSet<int>();
        for (int n = 0; n < matrix.Length; n++)
        {
            nums.Clear();
            for (int m = 0; m < matrix.Length; m++)
                if (nums.Contains(matrix[n][m]))
                    return false;
                else
                    nums.Add(matrix[n][m]);
        }
        for (int n = 0; n < matrix.Length; n++)
        {
            nums.Clear();
            for (int m = 0; m < matrix.Length; m++)
                if (nums.Contains(matrix[m][n]))
                    return false;
                else
                    nums.Add(matrix[m][n]);
        }
        return true;
    }
}
