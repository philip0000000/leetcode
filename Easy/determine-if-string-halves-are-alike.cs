public class Solution {
    public bool HalvesAreAlike(string s) {
        int l = 0, r = 0;
        for (int i = 0, j = s.Length-1; i < j; i++, j--)
        {
            if (s[i] == 'a' || s[i] == 'A' ||
                s[i] == 'e' || s[i] == 'E' ||
                s[i] == 'i' || s[i] == 'I' ||
                s[i] == 'o' || s[i] == 'O' ||
                s[i] == 'u' || s[i] == 'U')
            l++;
            if (s[j] == 'a' || s[j] == 'A' ||
                s[j] == 'e' || s[j] == 'E' ||
                s[j] == 'i' || s[j] == 'I' ||
                s[j] == 'o' || s[j] == 'O' ||
                s[j] == 'u' || s[j] == 'U')
            r++;
        }
        return l == r;
    }
}
