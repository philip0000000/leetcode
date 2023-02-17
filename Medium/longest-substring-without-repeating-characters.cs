// 1st
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int longest = 0;
        int c = 0;
        var dict = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (dict.ContainsKey(s[i]))
            {
                int t = i - dict[s[i]];
                c = Math.Min(c + 1, t) ;
                dict[s[i]] = i;
            }
            else
            {
                dict.Add(s[i], i);
                c++;
            }
            if (c > longest)
                longest = c;
        }
        return longest;
    }
}

// 2nd
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int longest = 0;
        int c = 0;
        var dict = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            c++;
            if (dict.ContainsKey(s[i]))
            {
                int t = i - dict[s[i]];
                c = Math.Min(c, t);
                dict[s[i]] = i;
            }
            else
                dict.Add(s[i], i);
            if (c > longest)
                longest = c;
        }
        return longest;
    }
}
