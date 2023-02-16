public class Solution {
    public bool CheckAlmostEquivalent(string word1, string word2) {
        var dict1 = new Dictionary<char, int>();
        for (int i = 0; i < word1.Length; i++)
            if (dict1.ContainsKey(word1[i]))
                dict1[word1[i]]++;
            else
                dict1.Add(word1[i], 1);
        var dict2 = new Dictionary<char, int>();
        for (int i = 0; i < word2.Length; i++)
            if (dict2.ContainsKey(word2[i]))
                dict2[word2[i]]++;
            else
                dict2.Add(word2[i], 1);
        foreach (var kvp in dict1)
        {
            if (dict2.ContainsKey(kvp.Key))
            {
                if (Math.Abs(kvp.Value - dict2[kvp.Key]) > 3)
                    return false;
            }
            else if (kvp.Value > 3)
                return false;
        }
        foreach (var kvp in dict2)
            if (!dict1.ContainsKey(kvp.Key) && kvp.Value > 3)
                return false;
        return true;
    }
}
