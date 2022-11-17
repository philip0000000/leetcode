public class Solution {
    private static string GetAlphanumericOnlyFromString(string input)
    {
        return new string(input.Where(c => char.IsLetterOrDigit(c)).ToArray());
    }

    public bool IsPalindrome(string s) {
        s = GetAlphanumericOnlyFromString(s);
        s = s.ToLower();

        if (s.Length == 0 || s.Length == 1)
            return true;

        for (int n = 0, m = s.Length / 2, l = s.Length - 1;
            n < m; n++, l--)
        {
            if (s[n] != s[l])
                return false;
        }

        return true;
    }
}
