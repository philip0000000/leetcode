public class Solution {
    public int CountBinarySubstrings(string s) {
        int ret = 0;
        for (int i = 0; i < s.Length-1; i++)
            if (s[i] != s[i+1])
            {
                int p0 = i, p1 = i+1;
                do {
                    ret++;
                    p0--;
                    p1++;
                } while (p0 >= 0 && p1 < s.Length && s[p0] != s[p1] &&
                        s[p0] == s[i] && s[p1] == s[i+1]);
            }
        return ret;
    }
}
