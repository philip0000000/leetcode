/**
 * @param {character[][]} board
 * @return {number}
 */
var countBattleships = function(board) {
    var ret = 0;
    for (var i = 0; i < board.length; i++)
        for (var j = 0; j < board[i].length; j++)
            if (board[i][j] == "X")
            {
                if (i == 0)
                {
                    if (j == 0)
                    {
                        ret++;
                        board[i][j] = ret;
                    }
                    else
                    {
                        if (board[i][j - 1] != "." && board[i][j - 1] != "X")
                            board[i][j] =  board[i][j - 1];
                        else
                        {
                            ret++;
                            board[i][j] = ret;
                        }
                    }
                }
                else if (j == 0)
                {
                    if (i == 0)
                    {
                        ret++;
                        board[i][j] = ret;
                    }
                    else
                    {
                        if (board[i - 1][j] != "." && board[i - 1][j] != "X")
                            board[i][j] =  board[i - 1][j];
                        else
                        {
                            ret++;
                            board[i][j] = ret;
                        }
                    }
                }
                else
                {
                    if (board[i][j - 1] != "." && board[i][j - 1] != "X")
                        board[i][j] =  board[i][j - 1];
                    else if (board[i - 1][j] != "." && board[i - 1][j] != "X")
                        board[i][j] =  board[i - 1][j];
                    else
                    {
                        ret++;
                        board[i][j] = ret;
                    }
                }
            }
    return ret;
};
