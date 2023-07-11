public class Solution {
    public string FrequencySort(string s) {
        var dict = new Dictionary<char, int>();
        foreach (char c in s)
            if (dict.ContainsKey(c))
                dict[c]++;
            else
                dict.Add(c, 1);

        var pq = new PriorityQueue<char, int>();
        foreach (var kvp in dict)
            pq.Enqueue(kvp.Key, -kvp.Value);
            
        var sb = new StringBuilder();
        while (pq.Count > 0)
        {
            pq.TryDequeue(out char c, out int i);
            sb.Append(new string(c, -i));
        }
        return sb.ToString();
    }
}
