// bad solution
public class Solution {
    public bool IsValidSudoku(char[][] board)
    {
        var nums = new HashSet<int>();
        for (int n = 0; n < board.Length; n++)
        {
            nums.Clear();
            for (int m = 0; m < board.Length; m++)
                if (board[n][m] != '.')
                {
                    if (nums.Contains(board[n][m]))
                        return false;
                    else
                        nums.Add(board[n][m]);
                }
        }
        for (int n = 0; n < board.Length; n++)
        {
            nums.Clear();
            for (int m = 0; m < board.Length; m++)
                if (board[m][n] != '.')
                {
                    if (nums.Contains(board[m][n]))
                        return false;
                    else
                        nums.Add(board[m][n]);
                }
        }
        for (int x = 0; x < 9; x += 3)
            for (int y = 0; y < 9; y += 3)
            {
                nums.Clear();
                for (int n = 0; n < 3; n++)
                    for (int m = 0; m < 3; m++)
                    {
                        if (board[x + n][y + m] != '.')
                        {
                            char c = board[x + n][y + m];
                            if (nums.Contains(c))
                                return false;
                            else
                                nums.Add(board[x + n][y + m]);
                        }
                    }
            }
        return true;
    }
}
