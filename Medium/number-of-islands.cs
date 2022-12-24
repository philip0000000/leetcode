public class Solution {
    public struct XY
    {
        public int x;
        public int y;
        public XY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public int NumIslands(char[][] grid) {
        int count = 0;
        int l = grid.Length;
        int l2 = grid[0].Length;
        for (int x = 0; x < l; x++)
            for (int y = 0; y < l2; y++)
                if (grid[x][y] == '1') // found a island
                {
                    count++;
                    // remove island
                    var st = new Stack<XY>();
                    st.Push(new XY(x, y));
                    grid[x][y] = '0';
                    while (st.Count > 0)
                    {
                        XY cell = st.Pop();
                        if (cell.x + 1 < l && grid[cell.x + 1][cell.y] == '1')
                        {
                            st.Push(new XY(cell.x + 1, cell.y));
                            grid[cell.x + 1][cell.y] = '0';
                        }
                        if (cell.x - 1 >= 0 && grid[cell.x - 1][cell.y] == '1')
                        {
                            st.Push(new XY(cell.x - 1, cell.y));
                            grid[cell.x - 1][cell.y] = '0';
                        }
                        if (cell.y + 1 < l2 && grid[cell.x][cell.y + 1] == '1')
                        {
                            st.Push(new XY(cell.x, cell.y + 1));
                            grid[cell.x][cell.y + 1] = '0';
                        }
                        if (cell.y - 1 >= 0 && grid[cell.x][cell.y - 1] == '1')
                        {
                            st.Push(new XY(cell.x, cell.y - 1));
                            grid[cell.x][cell.y - 1] = '0';
                        }
                    }
                }
        return count;
    }
}
