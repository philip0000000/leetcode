public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var dict = new Dictionary<int, int>();
        foreach (int i in arr)
            if (dict.ContainsKey(i))
                dict[i]++;
            else
                dict.Add(i, 1);
        var hs = new HashSet<int>();
        foreach (var kvp in dict)
            if (hs.Contains(kvp.Value))
                return false;
            else
                hs.Add(kvp.Value);
        return true;
    }
}
