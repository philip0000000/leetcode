public class Solution {
    public string ModifyString(string s) {
        var sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
            if (s[i] == '?')
            {
                if (i == 0)
                {
                    if (i+1 < s.Length)
                        sb.Append(s[i+1] == 'z' ? 'a' : 'z');
                    else
                        return "a";
                }
                else if (i == s.Length-1)
                {
                    char c = (char)(sb[sb.Length - 1]+1);
                    if (c >= 'z')
                        c = 'a';
                    sb.Append(c);
                }
                else
                {
                    char c = (char)(sb[sb.Length - 1]+1);
                    if (c >= 'z')
                        c = 'a';
                    if (c == s[i+1])
                        c++;
                    if (c >= 'z')
                        c = 'a';
                    sb.Append(c);
                }
            }
            else
                sb.Append(s[i]);
        return sb.ToString();
    }
}
