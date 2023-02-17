public class Solution {
    public IList<string> CommonChars(string[] words) {
        var dict = new Dictionary<char, int>();
        for (int j = 0; j < words[0].Length; j++)
        {
            if (dict.ContainsKey(words[0][j]))
                dict[words[0][j]]++;
            else
                dict.Add(words[0][j], 1);
        }
        for (int i = 1; i < words.Length; i++)
        {
            var tempDict = new Dictionary<char, int>();
            for (int j = 0; j < words[i].Length; j++)
            {
                if (tempDict.ContainsKey(words[i][j]))
                    tempDict[words[i][j]]++;
                else
                    tempDict.Add(words[i][j], 1);
            }
            var newDict = new Dictionary<char, int>();
            foreach (var kvp in dict)
                if (tempDict.ContainsKey(kvp.Key))
                    newDict.Add(kvp.Key, Math.Min(kvp.Value, tempDict[kvp.Key]));
            dict = newDict;
        }
        var list = new List<string>();
        foreach (var kvp in dict)
            for (int i = 0; i < kvp.Value; i++)
                list.Add(kvp.Key.ToString());
        return list;
    }
}
