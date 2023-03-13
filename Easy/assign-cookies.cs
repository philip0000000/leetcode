public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        int ret = 0;
        Array.Sort(g);
        Array.Sort(s);
        for (int p0 = g.Length-1, p1 = s.Length-1;
            p0 >= 0 && p1 >= 0; p0--, p1--)
        {
            while (p0 >= 0 && g[p0] > s[p1])
                    p0--;
            if (p0 >= 0 && g[p0] <= s[p1])
                ret++;
        }
        return ret;
    }
}
