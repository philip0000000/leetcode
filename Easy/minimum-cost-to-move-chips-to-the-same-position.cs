public class Solution {
    public int MinCostToMoveChips(int[] position) {
        var dict = new Dictionary<int, int>();
        for (int n = 0; n < position.Length; n++)
            if (dict.ContainsKey(position[n]))
                dict[position[n]]++;
            else
                dict.Add(position[n], 1);
        int AllModTwo = 0;
        int NotModTwo = 0;
        foreach (var kvp in dict)
        {
            if ((kvp.Key%2)==0)
                AllModTwo+=kvp.Value;
            else
                NotModTwo+=kvp.Value;
        }
        return Math.Min(AllModTwo, NotModTwo);
    }
}
