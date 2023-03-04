// 1st
public class Solution {
    public int SecondHighest(string s) {
        var hs = new HashSet<int>();
        foreach (char c in s)
            if (c >= '0' && c <= '9')
                hs.Add(c-'0');
        if (hs.Count < 2)
            return -1;
        var list = new List<int>();
        foreach (var n in hs)
            list.Add(n);
        list.Sort();
        return list[list.Count-2];
    }
}

// 2nd 50%~
public class Solution {
    public int SecondHighest(string s) {
        int L = -1, L2nd = -1;
        foreach (char c in s)
            if (c >= '0' && c <= '9')
            {
                if (c-'0' > L)
                {
                    L2nd = L;
                    L = c-'0';
                }
                else if (c-'0' > L2nd && c-'0' != L)
                    L2nd = c-'0';
            }
        return L2nd;
    }
}
