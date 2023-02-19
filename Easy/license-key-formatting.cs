public class Solution {
    public string LicenseKeyFormatting(string s, int k) {
        var sb = new StringBuilder();
        for (int i = s.Length-1, t = 0; i >= 0; i--)
            if (s[i] != '-')
            {
                char c = s[i];
                if ('a' <= c && c <= 'z')
                    c = (char)(c - 32);
                sb.Insert(0, c);
                t++;
                if (t == k)
                {
                    sb.Insert(0, '-');
                    t = 0;
                }
            }
        if (sb.Length > 0 && sb[0] == '-')
            sb.Remove(0, 1);
        return sb.ToString();
    }
}
