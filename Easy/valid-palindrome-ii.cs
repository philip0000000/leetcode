// https://leetcode.com/problems/valid-palindrome-ii/submissions/868622310/
public class Solution {
    public bool ValidPalindrome(string s) {
        if (s.Length == 2)
            return true;
        int i = 0, n = s.Length - 1;
        bool b = false;
        while (i < n)
        {
            if (s[i] == s[n])
            {
                n--;
                i++;
            }
            else
            {
                b = true;
                break;
            }
        }
        if (b)
        {
            b = false;
            int tl = i, tr = n - 1;
            while (tl < tr)
            {
                if (s[tl] == s[tr])
                {
                    tl++;
                    tr--;
                }
                else
                {
                    b = true;
                    break;
                }
            }
            if (b == false)
                return true;
            i++;
            while (i < n)
            {
                if (s[i] == s[n])
                {
                    i++;
                    n--;
                }
                else
                    return false;
            }
        }
        return true;
    }
}
