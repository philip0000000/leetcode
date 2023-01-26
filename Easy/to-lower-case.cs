public class Solution {
    public string ToLowerCase(string s) {
        StringBuilder sb = new StringBuilder(s);
        for (int i = 0; i < sb.Length; i++)
            if (sb[i] >= 'A' && sb[i] <= 'Z')
                sb[i] += (char)32;
        return sb.ToString();
    }
}
