public class Solution {
    public double ChampagneTower(int poured, int query_row, int query_glass) {
        var list = new List<double[]>();
        for (int i = 1; i <= query_row + 2; i++) // last glass row is "floor" (dynamic programming)
            list.Add(new double[i]);
        
        list[0][0] = (double)poured;

        for (int i = 0; i < query_row; i++)
            for (int j = 0; j < list[i].Length; j++)
            {
                double v = (list[i][j] - 1) / 2;
                if (v < 0)
                    v = 0;
                list[i+1][j] += v;
                list[i+1][j+1] += v;
            }

        if (list[query_row][query_glass] > 1)
            return 1;
        return list[query_row][query_glass];
    }
}
