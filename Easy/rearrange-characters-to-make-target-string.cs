public class Solution {
    public int RearrangeCharacters(string s, string target) {
        var dict = new Dictionary<char, int>();
        foreach (char c in target)
            if (dict.ContainsKey(c))
                dict[c]++;
            else
                dict.Add(c, 1);
        var dictNum = new Dictionary<char, int>();
        foreach (var kvp in dict)
            dictNum.Add(kvp.Key, 0);
        foreach (char c in s)
            if (dictNum.ContainsKey(c))
                dictNum[c]++;
        int lowest = Int32.MaxValue;
        foreach (var kvp in dictNum)
            if (kvp.Value/dict[kvp.Key] < lowest)
                lowest = kvp.Value/dict[kvp.Key];
        return lowest;
    }
}
