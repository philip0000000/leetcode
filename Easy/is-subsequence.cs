public class Solution {
    public bool IsSubsequence(string s, string t) {
        if (s.Length == 0)
            return true;

        int n = 0;
        for (int m = 0; m < t.Length; m++)
        {
            if (s[n] == t[m])
            {
                n++;
            	if (n == s.Length)
                	return true;
            }

        }

        return false;
    }
}
