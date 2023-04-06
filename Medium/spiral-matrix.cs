public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        var list = new List<int>();
        int x = 0, y = 0;
        int i = matrix.Length * matrix[0].Length;
        int xL = 0, xR = matrix[0].Length;
        int yU = 0, yD = matrix.Length;
        int direction = 0;
        while (i > 0)
        {
            list.Add(matrix[y][x]);
            switch (direction)
            {
                default:
                case 0:
                    if (x+1 < xR)
                        x++;
                    else
                    {
                        direction++;
                        y++;
                        yU++;
                    }
                    break;
                case 1:
                    if (y+1 < yD)
                        y++;
                    else
                    {
                        direction++;
                        x--;
                        xR--;
                    }
                    break;
                case 2:
                    if (x-1 >= xL)
                        x--;
                    else
                    {
                        direction++;
                        y--;
                        yD--;
                    }
                    break;
                case 3:
                    if (y-1 >= yU)
                        y--;
                    else
                    {
                        direction = 0;
                        x++;
                        xL++;
                    }
                    break;
            }
            i--;
        }
        return list;
    }
}
