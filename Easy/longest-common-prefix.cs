// 1st
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string ret = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            int n = 0;
            while (n < ret.Length && n < strs[i].Length && ret[n] == strs[i][n])
                n++;
            ret = ret.Substring(0, n);
        }
        return ret;
    }
}

// 2nd
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string ret = strs[0];
        int l = ret.Length;
        for (int i = 1; i < strs.Length; i++)
        {
            int n = 0;
            while (n < l && n < strs[i].Length && ret[n] == strs[i][n])
                n++;
            l = n;
        }
        return ret.Substring(0, l);
    }
}
