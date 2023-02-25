// https://leetcode.com/problems/count-prefixes-of-a-given-string/submissions/904591835/
public class Solution {
    public int CountPrefixes(string[] words, string s) {
        var dict = new Dictionary<string, int>();
        foreach (var n in words)
            if (dict.ContainsKey(n))
                dict[n]++;
            else
                dict.Add(n, 1);
        int ret = 0;
        var sb = new StringBuilder(s);
        while (sb.Length > 0)
        {
            if (dict.ContainsKey(sb.ToString()))
                ret += dict[sb.ToString()];
            sb.Length--;
        }
        return ret;
    }
}
