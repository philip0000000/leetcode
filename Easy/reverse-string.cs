// https://leetcode.com/problems/reverse-string/submissions/868810492/
public class Solution {
    public void ReverseString(char[] s) {
        for (int i = 0, n = s.Length - 1; i < n; i++, n--)
        {
            s[n] ^= s[i];
            s[i] ^= s[n];
            s[n] ^= s[i];
        }
    }
}
