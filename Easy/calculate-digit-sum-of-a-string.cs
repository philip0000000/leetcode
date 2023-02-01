public class Solution {
    public string DigitSum(string s, int k) {
        while (s.Length > k)
        {
            var sb = new StringBuilder();
            int temp = 0;
            int l = 0;
            for (int i = 0; i < s.Length; i++)
            {
                temp += s[i] - '0';
                l++;
                if (l == k)
                {
                    sb.Append(temp);
                    l = 0;
                    temp = 0;
                }
            }
            if (l > 0)
                sb.Append(temp);
            s = sb.ToString();
        }
        return s;
    }
}
