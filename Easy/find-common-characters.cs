// 1st
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

// 2nd https://leetcode.com/problems/find-common-characters/submissions/900001780/
public class Solution {
    public IList<string> CommonChars(string[] words) {
        var arr0 = new int[26];
        for (int j = 0; j < words[0].Length; j++)
            arr0[words[0][j] - 'a']++;
        for (int i = 1; i < words.Length; i++)
        {
            var arr1 = new int[26];
            for (int j = 0; j < words[i].Length; j++)
                arr1[words[i][j] - 'a']++;
            for (int n = 0; n < 26; n++)
                arr0[n] = Math.Min(arr0[n], arr1[n]);
        }
        var ret = new List<string>();
        for (int i = 0; i < 26; i++)
            for (int j = 0; j < arr0[i]; j++)
                ret.Add(((char)('a' + i)).ToString());
        return ret;
    }
}
