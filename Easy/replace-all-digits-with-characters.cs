// https://leetcode.com/problems/replace-all-digits-with-characters/submissions/903853175/
public class Solution {
    public char shift(char c, int n)
    {
        return (char)(c + n);
    }
    public string ReplaceDigits(string s) {
        var sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            if ((i%2)==0)
                sb.Append(s[i]);
            else
                sb.Append(shift(s[i-1], s[i]-'0'));
        }
        return sb.ToString();
    }
}
