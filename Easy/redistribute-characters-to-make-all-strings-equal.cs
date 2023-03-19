// 1st
public class Solution {
    public bool MakeEqual(string[] words) {
        var dict = new Dictionary<int, int>();
        foreach (var str in words)
        {
            foreach (var c in str)
                if (dict.ContainsKey(c))
                    dict[c]++;
                else
                    dict.Add(c, 1);
        }
        foreach (var kvp in dict)
            if ((kvp.Value%words.Length)!=0)
                return false;
        return true;
    }
}

// 2nd
public class Solution {
    public bool MakeEqual(string[] words) {
        var dict = new int[26];
        foreach (var str in words)
            foreach (var c in str)
                dict[c-'a']++;
        for (int i = 0; i < 26; i++)
            if ((dict[i]%words.Length)!=0)
                return false;
        return true;
    }
}
