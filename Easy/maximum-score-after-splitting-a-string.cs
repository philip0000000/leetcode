public class Solution {
    public int MaxScore(string s) {
        int zeros = s[0] == '0' ? 1 : 0;
        int one = 0;
        for (int i = s.Length-1; i > 0; i--)
            if (s[i]=='1')
                one++;
        int max = one + zeros;
        for (int i = 1; i < s.Length-1; i++)
        {
            if (s[i]=='0')
                zeros++;
            else
                one--;
            if (one + zeros > max)
                max = one + zeros;
        }
        return max;
    }
}
