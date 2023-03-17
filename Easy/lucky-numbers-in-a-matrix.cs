public class Solution {
    public IList<int> LuckyNumbers (int[][] matrix) {
        var list = new List<int>();
        // find minimum element in row
        for (int y = 0; y < matrix.Length; y++)
        {
            int IndexX = -1;
            int min = Int32.MaxValue;
            for (int tempX = 0; tempX < matrix[0].Length; tempX++)
                if (matrix[y][tempX] < min)
                {
                    min = matrix[y][tempX];
                    IndexX = tempX;
                }
            int tempY = y - 1;
            while (tempY >= 0 && matrix[tempY][IndexX] < min)
                tempY--;
            if (tempY == -1)
            {
                tempY = y + 1;
                while (tempY < matrix.Length && matrix[tempY][IndexX] < min)
                    tempY++;
                if (tempY == matrix.Length)
                    list.Add(matrix[y][IndexX]);
            }
        }
        return list;
    }
}
