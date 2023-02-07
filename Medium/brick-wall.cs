public class Solution {
    public int LeastBricks(IList<IList<int>> wall) {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < wall.Count; i++)
        {
            int sum = 0;
            for (int j = 0; j < wall[i].Count-1; j++)
            {
                sum += wall[i][j];
                if (dict.ContainsKey(sum))
                    dict[sum]++;
                else
                    dict.Add(sum, 1);
            }
        }
        int ret = Int32.MinValue;
        foreach (var kvp in dict)
            if (kvp.Value > ret)
                ret = kvp.Value;
        if (ret == Int32.MinValue)
            return wall.Count;
        return wall.Count-ret;
    }
}
