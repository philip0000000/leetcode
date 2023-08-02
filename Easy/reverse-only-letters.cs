public class Solution {
    public string ReverseOnlyLetters(string s) {
        var sb = new StringBuilder();
        int p0 = s.Length - 1;

        for (int i = 0; i < s.Length; i++)
            if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z'))
            {
                while (s[p0] < 'A' || (s[p0] > 'Z' && s[p0] < 'a'))
                    p0--;
                sb.Append(s[p0]);
                p0--;
            }
            else
                sb.Append(s[i]);
        return sb.ToString();
    }
}
