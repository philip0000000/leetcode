// 1st
public class Solution {
    public int NumSpecial(int[][] mat) {
        var list = new List<(int, int)>();
        for (int y = 0; y < mat.Length; y++)
            for (int x = 0; x < mat[0].Length; x++)
                if (mat[y][x] == 1)
                    list.Add((y, x));
        int ret = 0;
        for (int i = 0; i < list.Count; i++)
        {
            int f = 0;
            for (int n = 0; n < list.Count; n++)
                if (list[n].Item1 == list[i].Item1 || list[n].Item2 == list[i].Item2)
                {
                    f++;
                    if (f == 2)
                        break;
                }
            if (f == 1)
                ret++;
        }
        return ret;
    }
}

// 2nd
public class Solution {
    public int NumSpecial(int[][] mat) {
        var listY = new List<int>();
        var listX = new List<int>();
        for (int y = 0; y < mat.Length; y++)
        {
            int f = 0;
            int tx = 0;
            for (int x = 0; x < mat[0].Length; x++)
                if (mat[y][x] == 1)
                {
                    f++;
                    tx = x;
                    if (f==2)
                        break;
                }
            if (f==1)
            {
                listY.Add(y);
                listX.Add(tx);
            }
        }
        int ret = 0;
        for (int i = 0; i < listY.Count; i++)
        {
            int x = listX[i];
            int y = listY[i] - 1;
            while (y >= 0 && mat[y][x] == 0)
                y--;
            if (y==-1)
            {
                y = listY[i] + 1;
                while (y < mat.Length && mat[y][x] == 0)
                    y++;
                if (y == mat.Length)
                    ret++;
            }
        }
        return ret;
    }
}
