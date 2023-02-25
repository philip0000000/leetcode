public class Solution {
    public bool AreOccurrencesEqual(string s) {
        var dict = new Dictionary<char, int>();
        foreach (var c in s)
            if (dict.ContainsKey(c))
                dict[c]++;
            else
                dict.Add(c, 1);
        int cmp = 0;
        foreach(var kvp in dict)
        {
            cmp = kvp.Value;
            break;
        }
        foreach (var kvp in dict)
            if (kvp.Value != cmp)
                return false;
        return true;
    }
}
