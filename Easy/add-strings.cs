// https://leetcode.com/problems/add-strings/submissions/901465650/
public class Solution {
    public string AddStrings(string num1, string num2) {
        if (num2.Length>num1.Length)
        {
            string t = num1;
            num1 = num2;
            num2 = t;
        }
        var sb = new StringBuilder();
        int overflow = 0;
        int n = num1.Length-1;
        for (int i = num2.Length-1; i >= 0; i--, n--)
        {
            overflow += num1[n]-'0' + num2[i]-'0';
            sb.Insert(0, overflow%10);
            overflow/=10;
        }
        for (; n >= 0; n--)
        {
            overflow += num1[n]-'0';
            sb.Insert(0, overflow%10);
            overflow/=10;
        }
        while (overflow>0)
        {
            sb.Insert(0, overflow%10);
            overflow/=10;
        }
        return sb.ToString();
    }
}
