public class Solution {
    public int NumRookCaptures(char[][] board) {
        int x = 0;
        int y = 0;
        for (int i = 0; i < board.Length; i++)
            for (int j = 0; j < board[i].Length; j++)
                if (board[i][j]=='R')
                {
                    x = j;
                    y = i;
                    break;
                }
        int ret = 0;
        for (int n = x+1; n < board.Length; n++)
            if (board[y][n]!='.')
            {
                if (board[y][n]=='p')
                    ret++;
                break;
            }
        for (int n = x-1; n >= 0; n--)
            if (board[y][n]!='.')
            {
                if (board[y][n]=='p')
                    ret++;
                break;
            }
        for (int n = y+1; n < board.Length; n++)
            if (board[n][x]!='.')
            {
                if (board[n][x]=='p')
                    ret++;
                break;
            }
        for (int n = y-1; n >= 0; n--)
            if (board[n][x]!='.')
            {
                if (board[n][x]=='p')
                    ret++;
                break;
            }
        return ret;
    }
}
