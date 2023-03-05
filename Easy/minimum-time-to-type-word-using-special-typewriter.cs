public class Solution {
    public int MinTimeToType(string word) {
        int ret = 0;
        int pre = 0;
        foreach (char c in word)
        {
            int n = c - 'a';
            int v0 = Math.Max(pre, n) - Math.Min(pre, n);
            int v1 = 26 - v0;
            ret += 1 + Math.Min(v0, v1);
            pre = n;
        }
        return ret;
    }
}
