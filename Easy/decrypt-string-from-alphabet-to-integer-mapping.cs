public class Solution {
    public string FreqAlphabets(string s) {
        var sb = new StringBuilder();
        for (int i = s.Length-1; i >= 0; i--)
            if (s[i]=='#')
            {
                i-=2;
                int n = (s[i]-'0')*10;
                n += s[i+1]-'0';
                sb.Insert(0, (char)(96+n));
            }
            else
                sb.Insert(0, (char)(96+(s[i]-'0')));
        return sb.ToString();
    }
}
