// 1st
public class Solution {
    public bool BackspaceCompare(string s, string t) {
        int p0 = s.Length - 1, p1 = t.Length - 1;
        int p0b = 0, p1b = 0;
        while (p0 >= 0 && p1 >= 0)
            if (s[p0] == '#')
            {
                while (s[p0] == '#')
                {
                    p0--;
                    p0b++;
                }
            }
            else if (p0b > 0)
            {
                p0--;
                p0b--;
            }
            else if (t[p1] == '#')
            {
                while (t[p1] == '#')
                {
                    p1--;
                    p1b++;
                }
            }
            else if (p1b > 0)
            {
                p1--;
                p1b--;
            }
            else if (s[p0] == t[p1])
            {
                p0--;
                p1--;
            }
            else
                return false;
        while (p0 >= 0)
            if (s[p0] == '#')
            {
                while (p0 >= 0 && s[p0] == '#')
                {
                    p0--;
                    p0b++;
                }
            }
            else if (p0b > 0)
            {
                p0--;
                p0b--;
            }
            else
                break;
        while (p1 >= 0)
            if (t[p1] == '#')
            {
                while (p1 >= 0 && t[p1] == '#')
                {
                    p1--;
                    p1b++;
                }
            }
            else if (p1b > 0)
            {
                p1--;
                p1b--;
            }
            else
                break;
        return p0 == -1 && p1 == -1;
    }
}

// 2nd
public class Solution {
    public bool BackspaceCompare(string s, string t) {
        var sb0 = new StringBuilder();
        var sb1 = new StringBuilder();
        int b = 0;
        for (int i = s.Length-1; i >= 0; i--)
            if (s[i] == '#')
                b++;
            else if (b > 0)
                b--;
            else
                sb0.Append(s[i]);
        b = 0;
        for (int i = t.Length-1; i >= 0; i--)
            if (t[i] == '#')
                b++;
            else if (b > 0)
                b--;
            else
                sb1.Append(t[i]);
        return sb0.ToString() == sb1.ToString();
    }
}

// 3rd https://leetcode.com/problems/backspace-string-compare/submissions/922032240/
public class Solution {
    public bool BackspaceCompare(string s, string t) {
        int hash0 = 5381;
        int hash1 = 5381;
        int prime = 33;
        int b = 0;
        for (int i = s.Length-1; i >= 0; i--)
            if (s[i] == '#')
                b++;
            else if (b > 0)
                b--;
            else
                hash0 = (hash0 * prime) + (int)s[i];
        b = 0;
        for (int i = t.Length-1; i >= 0; i--)
            if (t[i] == '#')
                b++;
            else if (b > 0)
                b--;
            else
                hash1 = (hash1 * prime) + (int)t[i];
        return hash0 == hash1;
    }
}
