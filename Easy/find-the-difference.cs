public class Solution {
    public char FindTheDifference(string s, string t) {
        var dict0 = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
            if (dict0.ContainsKey(s[i]))
                dict0[s[i]]++;
            else
                dict0.Add(s[i], 1);
        var dict1 = new Dictionary<char, int>();
        for (int i = 0; i < t.Length; i++)
            if (dict1.ContainsKey(t[i]))
                dict1[t[i]]++;
            else
                dict1.Add(t[i], 1);
        foreach (var kvp in dict1)
            if (dict0.ContainsKey(kvp.Key) == false ||
                kvp.Value != dict0[kvp.Key])
                return kvp.Key;
        return s[0];
    }
}
