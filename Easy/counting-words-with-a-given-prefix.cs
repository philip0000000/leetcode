public class Solution {
    public int PrefixCount(string[] words, string pref) {
        int ret = 0;
        foreach (var str in words)
            if (str.StartsWith(pref))
                ret++;
        return ret;
    }
}
